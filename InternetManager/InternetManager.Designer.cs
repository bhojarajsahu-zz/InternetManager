namespace InternetManager
{
	partial class InternetManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetManager));
			this.groupBoxAllAdapter = new System.Windows.Forms.GroupBox();
			this.buttonRemoveAdapter = new System.Windows.Forms.Button();
			this.buttonAddAdapter = new System.Windows.Forms.Button();
			this.listBoxSelectedAdapter = new System.Windows.Forms.ListBox();
			this.listBoxAllAdapter = new System.Windows.Forms.ListBox();
			this.groupBoxAllApps = new System.Windows.Forms.GroupBox();
			this.buttonRemoveApps = new System.Windows.Forms.Button();
			this.listBoxAllApps = new System.Windows.Forms.ListBox();
			this.buttonAddApps = new System.Windows.Forms.Button();
			this.groupBoxTime = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
			this.labelStartTime = new System.Windows.Forms.Label();
			this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
			this.buttonRemoveTime = new System.Windows.Forms.Button();
			this.listBoxAllTime = new System.Windows.Forms.ListBox();
			this.buttonTime = new System.Windows.Forms.Button();
			this.timerManager = new System.Windows.Forms.Timer(this.components);
			this.openFileDialogAppManager = new System.Windows.Forms.OpenFileDialog();
			this.groupBoxAllAdapter.SuspendLayout();
			this.groupBoxAllApps.SuspendLayout();
			this.groupBoxTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxAllAdapter
			// 
			this.groupBoxAllAdapter.Controls.Add(this.buttonRemoveAdapter);
			this.groupBoxAllAdapter.Controls.Add(this.buttonAddAdapter);
			this.groupBoxAllAdapter.Controls.Add(this.listBoxSelectedAdapter);
			this.groupBoxAllAdapter.Controls.Add(this.listBoxAllAdapter);
			this.groupBoxAllAdapter.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBoxAllAdapter.Location = new System.Drawing.Point(0, 0);
			this.groupBoxAllAdapter.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxAllAdapter.Name = "groupBoxAllAdapter";
			this.groupBoxAllAdapter.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxAllAdapter.Size = new System.Drawing.Size(309, 458);
			this.groupBoxAllAdapter.TabIndex = 0;
			this.groupBoxAllAdapter.TabStop = false;
			this.groupBoxAllAdapter.Text = "All Adapters";
			this.groupBoxAllAdapter.Enter += new System.EventHandler(this.groupBoxAllAdapter_Enter);
			// 
			// buttonRemoveAdapter
			// 
			this.buttonRemoveAdapter.Location = new System.Drawing.Point(177, 218);
			this.buttonRemoveAdapter.Margin = new System.Windows.Forms.Padding(4);
			this.buttonRemoveAdapter.Name = "buttonRemoveAdapter";
			this.buttonRemoveAdapter.Size = new System.Drawing.Size(124, 36);
			this.buttonRemoveAdapter.TabIndex = 5;
			this.buttonRemoveAdapter.Text = "Remove Adapter";
			this.buttonRemoveAdapter.UseVisualStyleBackColor = true;
			this.buttonRemoveAdapter.Click += new System.EventHandler(this.buttonRemoveAdapter_Click);
			// 
			// buttonAddAdapter
			// 
			this.buttonAddAdapter.Location = new System.Drawing.Point(8, 218);
			this.buttonAddAdapter.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAddAdapter.Name = "buttonAddAdapter";
			this.buttonAddAdapter.Size = new System.Drawing.Size(124, 36);
			this.buttonAddAdapter.TabIndex = 4;
			this.buttonAddAdapter.Text = "Add Adapter";
			this.buttonAddAdapter.UseVisualStyleBackColor = true;
			this.buttonAddAdapter.Click += new System.EventHandler(this.buttonAddAdapter_Click);
			// 
			// listBoxSelectedAdapter
			// 
			this.listBoxSelectedAdapter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listBoxSelectedAdapter.FormattingEnabled = true;
			this.listBoxSelectedAdapter.ItemHeight = 16;
			this.listBoxSelectedAdapter.Location = new System.Drawing.Point(4, 274);
			this.listBoxSelectedAdapter.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxSelectedAdapter.Name = "listBoxSelectedAdapter";
			this.listBoxSelectedAdapter.Size = new System.Drawing.Size(301, 180);
			this.listBoxSelectedAdapter.TabIndex = 1;
			// 
			// listBoxAllAdapter
			// 
			this.listBoxAllAdapter.Dock = System.Windows.Forms.DockStyle.Top;
			this.listBoxAllAdapter.FormattingEnabled = true;
			this.listBoxAllAdapter.ItemHeight = 16;
			this.listBoxAllAdapter.Location = new System.Drawing.Point(4, 19);
			this.listBoxAllAdapter.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxAllAdapter.Name = "listBoxAllAdapter";
			this.listBoxAllAdapter.Size = new System.Drawing.Size(301, 180);
			this.listBoxAllAdapter.TabIndex = 0;
			// 
			// groupBoxAllApps
			// 
			this.groupBoxAllApps.Controls.Add(this.buttonRemoveApps);
			this.groupBoxAllApps.Controls.Add(this.listBoxAllApps);
			this.groupBoxAllApps.Controls.Add(this.buttonAddApps);
			this.groupBoxAllApps.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBoxAllApps.Location = new System.Drawing.Point(309, 0);
			this.groupBoxAllApps.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxAllApps.Name = "groupBoxAllApps";
			this.groupBoxAllApps.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxAllApps.Size = new System.Drawing.Size(529, 458);
			this.groupBoxAllApps.TabIndex = 1;
			this.groupBoxAllApps.TabStop = false;
			this.groupBoxAllApps.Text = "All Apps";
			// 
			// buttonRemoveApps
			// 
			this.buttonRemoveApps.Location = new System.Drawing.Point(140, 406);
			this.buttonRemoveApps.Margin = new System.Windows.Forms.Padding(4);
			this.buttonRemoveApps.Name = "buttonRemoveApps";
			this.buttonRemoveApps.Size = new System.Drawing.Size(124, 36);
			this.buttonRemoveApps.TabIndex = 3;
			this.buttonRemoveApps.Text = "Remove Apps";
			this.buttonRemoveApps.UseVisualStyleBackColor = true;
			this.buttonRemoveApps.Click += new System.EventHandler(this.buttonRemoveApps_Click);
			// 
			// listBoxAllApps
			// 
			this.listBoxAllApps.Dock = System.Windows.Forms.DockStyle.Top;
			this.listBoxAllApps.FormattingEnabled = true;
			this.listBoxAllApps.ItemHeight = 16;
			this.listBoxAllApps.Location = new System.Drawing.Point(4, 19);
			this.listBoxAllApps.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxAllApps.Name = "listBoxAllApps";
			this.listBoxAllApps.Size = new System.Drawing.Size(521, 372);
			this.listBoxAllApps.TabIndex = 2;
			// 
			// buttonAddApps
			// 
			this.buttonAddApps.Location = new System.Drawing.Point(8, 406);
			this.buttonAddApps.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAddApps.Name = "buttonAddApps";
			this.buttonAddApps.Size = new System.Drawing.Size(124, 36);
			this.buttonAddApps.TabIndex = 1;
			this.buttonAddApps.Text = "Add Apps";
			this.buttonAddApps.UseVisualStyleBackColor = true;
			this.buttonAddApps.Click += new System.EventHandler(this.buttonAddApps_Click);
			// 
			// groupBoxTime
			// 
			this.groupBoxTime.Controls.Add(this.label1);
			this.groupBoxTime.Controls.Add(this.dateTimePickerEndTime);
			this.groupBoxTime.Controls.Add(this.labelStartTime);
			this.groupBoxTime.Controls.Add(this.dateTimePickerStartTime);
			this.groupBoxTime.Controls.Add(this.buttonRemoveTime);
			this.groupBoxTime.Controls.Add(this.listBoxAllTime);
			this.groupBoxTime.Controls.Add(this.buttonTime);
			this.groupBoxTime.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBoxTime.Location = new System.Drawing.Point(838, 0);
			this.groupBoxTime.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxTime.Name = "groupBoxTime";
			this.groupBoxTime.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxTime.Size = new System.Drawing.Size(309, 458);
			this.groupBoxTime.TabIndex = 2;
			this.groupBoxTime.TabStop = false;
			this.groupBoxTime.Text = "All Time";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 332);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "End Time";
			// 
			// dateTimePickerEndTime
			// 
			this.dateTimePickerEndTime.CustomFormat = "MM/dd/yyyy h:mm tt";
			this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerEndTime.Location = new System.Drawing.Point(8, 351);
			this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
			this.dateTimePickerEndTime.Size = new System.Drawing.Size(175, 22);
			this.dateTimePickerEndTime.TabIndex = 6;
			this.dateTimePickerEndTime.Value = new System.DateTime(2017, 11, 30, 22, 2, 0, 0);
			// 
			// labelStartTime
			// 
			this.labelStartTime.AutoSize = true;
			this.labelStartTime.Location = new System.Drawing.Point(7, 273);
			this.labelStartTime.Name = "labelStartTime";
			this.labelStartTime.Size = new System.Drawing.Size(69, 16);
			this.labelStartTime.TabIndex = 5;
			this.labelStartTime.Text = "Start Time";
			// 
			// dateTimePickerStartTime
			// 
			this.dateTimePickerStartTime.CustomFormat = "MM/dd/yyyy h:mm tt";
			this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerStartTime.Location = new System.Drawing.Point(8, 292);
			this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
			this.dateTimePickerStartTime.Size = new System.Drawing.Size(175, 22);
			this.dateTimePickerStartTime.TabIndex = 4;
			this.dateTimePickerStartTime.Value = new System.DateTime(2017, 11, 30, 22, 2, 0, 0);
			// 
			// buttonRemoveTime
			// 
			this.buttonRemoveTime.Location = new System.Drawing.Point(177, 406);
			this.buttonRemoveTime.Margin = new System.Windows.Forms.Padding(4);
			this.buttonRemoveTime.Name = "buttonRemoveTime";
			this.buttonRemoveTime.Size = new System.Drawing.Size(124, 36);
			this.buttonRemoveTime.TabIndex = 3;
			this.buttonRemoveTime.Text = "Remove Time";
			this.buttonRemoveTime.UseVisualStyleBackColor = true;
			this.buttonRemoveTime.Click += new System.EventHandler(this.buttonRemoveTime_Click);
			// 
			// listBoxAllTime
			// 
			this.listBoxAllTime.Dock = System.Windows.Forms.DockStyle.Top;
			this.listBoxAllTime.FormattingEnabled = true;
			this.listBoxAllTime.ItemHeight = 16;
			this.listBoxAllTime.Location = new System.Drawing.Point(4, 19);
			this.listBoxAllTime.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxAllTime.Name = "listBoxAllTime";
			this.listBoxAllTime.Size = new System.Drawing.Size(301, 212);
			this.listBoxAllTime.TabIndex = 2;
			// 
			// buttonTime
			// 
			this.buttonTime.Location = new System.Drawing.Point(8, 406);
			this.buttonTime.Margin = new System.Windows.Forms.Padding(4);
			this.buttonTime.Name = "buttonTime";
			this.buttonTime.Size = new System.Drawing.Size(124, 36);
			this.buttonTime.TabIndex = 1;
			this.buttonTime.Text = "Add Time";
			this.buttonTime.UseVisualStyleBackColor = true;
			this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
			// 
			// timerManager
			// 
			this.timerManager.Enabled = true;
			this.timerManager.Interval = 1000;
			this.timerManager.Tick += new System.EventHandler(this.timerManager_Tick);
			// 
			// openFileDialogAppManager
			// 
			this.openFileDialogAppManager.FileName = "App Manager";
			this.openFileDialogAppManager.Filter = "EXE|*.exe";
			this.openFileDialogAppManager.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogAppManager_FileOk);
			// 
			// InternetManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 458);
			this.Controls.Add(this.groupBoxTime);
			this.Controls.Add(this.groupBoxAllApps);
			this.Controls.Add(this.groupBoxAllAdapter);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1166, 497);
			this.MinimumSize = new System.Drawing.Size(1166, 497);
			this.Name = "InternetManager";
			this.Text = "Internet Manager";
			this.Load += new System.EventHandler(this.InternetManager_Load);
			this.groupBoxAllAdapter.ResumeLayout(false);
			this.groupBoxAllApps.ResumeLayout(false);
			this.groupBoxTime.ResumeLayout(false);
			this.groupBoxTime.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxAllAdapter;
		private System.Windows.Forms.ListBox listBoxAllAdapter;
		private System.Windows.Forms.GroupBox groupBoxAllApps;
		private System.Windows.Forms.Button buttonAddApps;
		private System.Windows.Forms.ListBox listBoxAllApps;
		private System.Windows.Forms.Button buttonRemoveApps;
		private System.Windows.Forms.GroupBox groupBoxTime;
		private System.Windows.Forms.Button buttonRemoveTime;
		private System.Windows.Forms.ListBox listBoxAllTime;
		private System.Windows.Forms.Button buttonTime;
		private System.Windows.Forms.ListBox listBoxSelectedAdapter;
		private System.Windows.Forms.Button buttonRemoveAdapter;
		private System.Windows.Forms.Button buttonAddAdapter;
		private System.Windows.Forms.Timer timerManager;
		private System.Windows.Forms.OpenFileDialog openFileDialogAppManager;
		private System.Windows.Forms.Label labelStartTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
	}
}

