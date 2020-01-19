using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace InternetManager
{
	public partial class InternetManager : Form
	{
		public string Adapter = string.Empty;
		public List<string> Applications = new List<string>();
		public string StartTimeEndTime = string.Empty;
		bool Status = false;
		bool ExitStatus = false;
		public InternetManager()
		{
			InitializeComponent();
		}

		private void InternetManager_Load(object sender, EventArgs e)
		{
			GetNetworkInterface();
		}
		public void GetNetworkInterface()
		{
			try
			{
				SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
				ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(wmiQuery);
				foreach (ManagementObject item in searchProcedure.Get())
					listBoxAllAdapter.Items.Add((string)item["NetConnectionId"]);

			}
			catch(Exception ex){}
		}

		private void groupBoxAllAdapter_Enter(object sender, EventArgs e)
		{

		}

		private void buttonAddAdapter_Click(object sender, EventArgs e)
		{
			try
			{
				if (listBoxAllAdapter.SelectedIndex > 0)
				{
					if (listBoxSelectedAdapter.Items.Count > 0)
						listBoxSelectedAdapter.Items.Clear();

					listBoxSelectedAdapter.Items.Add(listBoxAllAdapter.SelectedItem);
					Adapter = listBoxAllAdapter.SelectedItem.ToString();
					EnableAdapter(Adapter, true);
				}
			}
			catch(Exception ex){}
		}

		private void buttonRemoveAdapter_Click(object sender, EventArgs e)
		{
			try
			{
				if (listBoxSelectedAdapter.Items.Count > 0)
					listBoxSelectedAdapter.Items.Clear();

			}catch(Exception ex){}
		}

		private void buttonAddApps_Click(object sender, EventArgs e)
		{
			try
			{
				openFileDialogAppManager.ShowDialog();
			}
			catch (Exception ex) { }			
		}

		private void buttonRemoveApps_Click(object sender, EventArgs e)
		{
			try
			{
				if (listBoxAllApps.SelectedItem != null)
					listBoxAllApps.Items.Remove(listBoxAllApps.SelectedItem);

			}
			catch (Exception ex) { }
		}

		private void buttonTime_Click(object sender, EventArgs e)
		{
			try
			{
				if (listBoxAllTime.Items.Count > 0)
					listBoxAllTime.Items.Clear();

				DateTime start = dateTimePickerStartTime.Value;
				DateTime end = dateTimePickerEndTime.Value;
				if (start < end)
				{
					listBoxAllTime.Items.Add(string.Format("{0} | {1}", dateTimePickerStartTime.Value, dateTimePickerEndTime.Value));
					StartTimeEndTime = string.Format("{0} | {1}", dateTimePickerStartTime.Value, dateTimePickerEndTime.Value);
				}
				else
					MessageBox.Show("No time difference", "Internet manager");
			}
			catch (Exception ex) { }
		}

		private void buttonRemoveTime_Click(object sender, EventArgs e)
		{
			try
			{
				if (listBoxAllTime.Items.Count > 0)
					listBoxAllTime.Items.Clear();
				//if (listBoxAllTime.SelectedItem != null)
				//	listBoxAllTime.Items.Remove(listBoxAllTime.SelectedItem);

			}
			catch (Exception ex) { }
		}

		private void openFileDialogAppManager_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				string fileName = openFileDialogAppManager.FileName;
				listBoxAllApps.Items.Add(fileName);
				Applications.Add(fileName);
			}
			catch (Exception ex) { }
		}

		private void timerManager_Tick(object sender, EventArgs e)
		{
			try
			{
				if(!string.IsNullOrEmpty(Adapter))
					if(Applications.Count > 0)
						if (listBoxAllTime.Items.Count > 0)
						{
							DateTime startTime = Convert.ToDateTime(StartTimeEndTime.Split('|')[0]);
							DateTime endTime = Convert.ToDateTime(StartTimeEndTime.Split('|')[1]);

							if (endTime < DateTime.Now)
							{
								if (!ExitStatus)
								{
									foreach (string app in Applications)
									{
										string processName = Path.GetFileName(app);
										processName = processName.Split('.')[0];
										Process[] processlist = Process.GetProcesses();
										foreach (Process theProcess in processlist)
											if (theProcess.ProcessName == processName)
												theProcess.Kill();
									}

									ExitStatus = true;
								}
							}
							if (DateTime.Now > startTime)
							{
								if (!Status)
								{
									EnableAdapter(Adapter, true);
									foreach (string app in Applications)
										Process.Start(app);

									Status = true;
								}
							}
							
						}
			}
			catch(Exception ex){}
		}
		public void EnableAdapter(string adapterName , bool adapterStatus)
		{
			try
			{
				ManagementObject currentMObject = new ManagementObject();
				string strWQuery = "SELECT DeviceID,ProductName,Description,NetEnabled "
					+ "FROM Win32_NetworkAdapter ";
				ObjectQuery oQuery = new System.Management.ObjectQuery(strWQuery);
				ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oQuery);
				ManagementObjectCollection oReturnCollection = oSearcher.Get();

				foreach (ManagementObject mo in oReturnCollection)
				{
					currentMObject = mo;
					if (adapterStatus)
					{
						if ((string)currentMObject["NetConnectionId"] == adapterName)
							currentMObject.InvokeMethod("Enable", null);
						else
							currentMObject.InvokeMethod("Disable", null);
					}
					else
					{
						currentMObject.InvokeMethod("Disable", null);
					}
				} 
			}
			catch(Exception ex){}
		}
	}
}
