
namespace Labor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Button_Logout = new System.Windows.Forms.Button();
            this.Label_Info = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataGridViewTimeEntry = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogOutputTextBox = new System.Windows.Forms.TextBox();
            this.Button_CopyLog = new System.Windows.Forms.Button();
            this.PanelState = new System.Windows.Forms.Panel();
            this.LabelTimeHeadText = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelTimeFootText = new System.Windows.Forms.Label();
            this.LabelPercent = new System.Windows.Forms.Label();
            this.LabelPercentText = new System.Windows.Forms.Label();
            this.DataGridViewIssues = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Button_WatcherList = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStripForNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AutoStart = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Today = new System.Windows.Forms.Button();
            this.Label_CurrentRequestCountText = new System.Windows.Forms.Label();
            this.Label_CurrentRequestCount = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_GetIssue = new System.Windows.Forms.Timer(this.components);
            this.Button_RefreshIssue = new System.Windows.Forms.Button();
            this.PictureBox_Loading = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuickControllButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimeEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIssues)).BeginInit();
            this.ContextMenuStripForNotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Logout
            // 
            this.Button_Logout.Location = new System.Drawing.Point(865, 6);
            this.Button_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(37, 21);
            this.Button_Logout.TabIndex = 0;
            this.Button_Logout.Text = "登出";
            this.Button_Logout.UseVisualStyleBackColor = true;
            this.Button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // Label_Info
            // 
            this.Label_Info.AutoSize = true;
            this.Label_Info.Location = new System.Drawing.Point(769, 11);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(41, 12);
            this.Label_Info.TabIndex = 1;
            this.Label_Info.Text = "用户名";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(181, 268);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(139, 21);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.Value = new System.DateTime(2021, 4, 24, 23, 59, 59, 0);
            this.DateTimePicker.CloseUp += new System.EventHandler(this.DateTimePicker_CloseUp);
            // 
            // DataGridViewTimeEntry
            // 
            this.DataGridViewTimeEntry.AllowUserToAddRows = false;
            this.DataGridViewTimeEntry.AllowUserToDeleteRows = false;
            this.DataGridViewTimeEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewTimeEntry.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewTimeEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTimeEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProjectName,
            this.SubjectId,
            this.Subject,
            this.Comments,
            this.Percent,
            this.Hours});
            this.DataGridViewTimeEntry.Location = new System.Drawing.Point(10, 293);
            this.DataGridViewTimeEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewTimeEntry.Name = "DataGridViewTimeEntry";
            this.DataGridViewTimeEntry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewTimeEntry.RowHeadersVisible = false;
            this.DataGridViewTimeEntry.RowTemplate.Height = 25;
            this.DataGridViewTimeEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewTimeEntry.Size = new System.Drawing.Size(754, 107);
            this.DataGridViewTimeEntry.TabIndex = 4;
            this.DataGridViewTimeEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTimeEntry_CellContentClick);
            this.DataGridViewTimeEntry.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTimeEntry_CellValueChanged);
            this.DataGridViewTimeEntry.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridViewTimeEntry_CurrentCellDirtyStateChanged);
            this.DataGridViewTimeEntry.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGridViewTimeEntry_Scroll);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.FillWeight = 15F;
            this.ProjectName.HeaderText = "项目";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.HeaderText = "SubjectId";
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            this.SubjectId.Visible = false;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.FillWeight = 19F;
            this.Subject.HeaderText = "任务";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.FillWeight = 45F;
            this.Comments.HeaderText = "注释";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "Percent";
            this.Percent.FillWeight = 6F;
            this.Percent.HeaderText = "%";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "Hours";
            this.Hours.FillWeight = 9F;
            this.Hours.HeaderText = "耗时";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            // 
            // LogOutputTextBox
            // 
            this.LogOutputTextBox.Location = new System.Drawing.Point(770, 293);
            this.LogOutputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutputTextBox.Multiline = true;
            this.LogOutputTextBox.Name = "LogOutputTextBox";
            this.LogOutputTextBox.ReadOnly = true;
            this.LogOutputTextBox.Size = new System.Drawing.Size(235, 107);
            this.LogOutputTextBox.TabIndex = 5;
            // 
            // Button_CopyLog
            // 
            this.Button_CopyLog.Location = new System.Drawing.Point(927, 378);
            this.Button_CopyLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_CopyLog.Name = "Button_CopyLog";
            this.Button_CopyLog.Size = new System.Drawing.Size(78, 22);
            this.Button_CopyLog.TabIndex = 6;
            this.Button_CopyLog.Text = "复制任务";
            this.Button_CopyLog.UseVisualStyleBackColor = true;
            this.Button_CopyLog.Click += new System.EventHandler(this.Button_CopyLog_Click);
            // 
            // PanelState
            // 
            this.PanelState.BackColor = System.Drawing.Color.Green;
            this.PanelState.Location = new System.Drawing.Point(124, 271);
            this.PanelState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelState.Name = "PanelState";
            this.PanelState.Size = new System.Drawing.Size(22, 16);
            this.PanelState.TabIndex = 8;
            // 
            // LabelTimeHeadText
            // 
            this.LabelTimeHeadText.AutoSize = true;
            this.LabelTimeHeadText.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTimeHeadText.Location = new System.Drawing.Point(9, 271);
            this.LabelTimeHeadText.Name = "LabelTimeHeadText";
            this.LabelTimeHeadText.Size = new System.Drawing.Size(55, 15);
            this.LabelTimeHeadText.TabIndex = 9;
            this.LabelTimeHeadText.Text = "工时：";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(58, 273);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(29, 12);
            this.LabelTime.TabIndex = 10;
            this.LabelTime.Text = "00.0";
            // 
            // LabelTimeFootText
            // 
            this.LabelTimeFootText.AutoSize = true;
            this.LabelTimeFootText.Location = new System.Drawing.Point(93, 273);
            this.LabelTimeFootText.Name = "LabelTimeFootText";
            this.LabelTimeFootText.Size = new System.Drawing.Size(29, 12);
            this.LabelTimeFootText.TabIndex = 11;
            this.LabelTimeFootText.Text = "小时";
            // 
            // LabelPercent
            // 
            this.LabelPercent.AutoSize = true;
            this.LabelPercent.Location = new System.Drawing.Point(148, 273);
            this.LabelPercent.Name = "LabelPercent";
            this.LabelPercent.Size = new System.Drawing.Size(23, 12);
            this.LabelPercent.TabIndex = 12;
            this.LabelPercent.Text = "100";
            this.LabelPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPercentText
            // 
            this.LabelPercentText.AutoSize = true;
            this.LabelPercentText.Location = new System.Drawing.Point(168, 273);
            this.LabelPercentText.Name = "LabelPercentText";
            this.LabelPercentText.Size = new System.Drawing.Size(11, 12);
            this.LabelPercentText.TabIndex = 13;
            this.LabelPercentText.Text = "%";
            // 
            // DataGridViewIssues
            // 
            this.DataGridViewIssues.AllowUserToAddRows = false;
            this.DataGridViewIssues.AllowUserToDeleteRows = false;
            this.DataGridViewIssues.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.dataGridViewTextBoxColumn5,
            this.QuickControllButton});
            this.DataGridViewIssues.Location = new System.Drawing.Point(10, 31);
            this.DataGridViewIssues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewIssues.Name = "DataGridViewIssues";
            this.DataGridViewIssues.ReadOnly = true;
            this.DataGridViewIssues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewIssues.RowHeadersVisible = false;
            this.DataGridViewIssues.RowTemplate.Height = 25;
            this.DataGridViewIssues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewIssues.Size = new System.Drawing.Size(995, 233);
            this.DataGridViewIssues.TabIndex = 14;
            this.DataGridViewIssues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewIssues_CellContentClick);
            this.DataGridViewIssues.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewIssues_CellValueChanged);
            this.DataGridViewIssues.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGridViewIssues_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1110, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 21);
            this.button1.TabIndex = 15;
            this.button1.Text = "新增Issue(未实现)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1027, 170);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 16);
            this.button2.TabIndex = 16;
            this.button2.Text = "修改Issue(未实现)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(513, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "新增Issue(未实现)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(610, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "修改Issue(未实现)";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1110, 116);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 20);
            this.button3.TabIndex = 18;
            this.button3.Text = "修改工时(未实现)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1027, 116);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 20);
            this.button4.TabIndex = 17;
            this.button4.Text = "新增工时(未实现)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Button_WatcherList
            // 
            this.Button_WatcherList.Location = new System.Drawing.Point(181, 5);
            this.Button_WatcherList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_WatcherList.Name = "Button_WatcherList";
            this.Button_WatcherList.Size = new System.Drawing.Size(83, 22);
            this.Button_WatcherList.TabIndex = 21;
            this.Button_WatcherList.Text = "观察者列表";
            this.Button_WatcherList.UseVisualStyleBackColor = true;
            this.Button_WatcherList.Click += new System.EventHandler(this.Button_WatcherList_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipTitle = "RedMine填写";
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStripForNotifyIcon;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Labor";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // ContextMenuStripForNotifyIcon
            // 
            this.ContextMenuStripForNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoStart,
            this.Quit});
            this.ContextMenuStripForNotifyIcon.Name = "ContextMenuStripForNotifyIcon";
            this.ContextMenuStripForNotifyIcon.ShowImageMargin = false;
            this.ContextMenuStripForNotifyIcon.Size = new System.Drawing.Size(100, 48);
            // 
            // AutoStart
            // 
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(99, 22);
            this.AutoStart.Text = "开机启动";
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(99, 22);
            this.Quit.Text = "退出";
            // 
            // Button_Today
            // 
            this.Button_Today.Location = new System.Drawing.Point(326, 268);
            this.Button_Today.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Today.Name = "Button_Today";
            this.Button_Today.Size = new System.Drawing.Size(78, 22);
            this.Button_Today.TabIndex = 23;
            this.Button_Today.Text = "选中今天";
            this.Button_Today.UseVisualStyleBackColor = true;
            this.Button_Today.Click += new System.EventHandler(this.Button_Today_Click);
            // 
            // Label_CurrentRequestCountText
            // 
            this.Label_CurrentRequestCountText.AutoSize = true;
            this.Label_CurrentRequestCountText.Location = new System.Drawing.Point(1024, 11);
            this.Label_CurrentRequestCountText.Name = "Label_CurrentRequestCountText";
            this.Label_CurrentRequestCountText.Size = new System.Drawing.Size(77, 12);
            this.Label_CurrentRequestCountText.TabIndex = 26;
            this.Label_CurrentRequestCountText.Text = "当前请求数量";
            this.Label_CurrentRequestCountText.Visible = false;
            // 
            // Label_CurrentRequestCount
            // 
            this.Label_CurrentRequestCount.AutoSize = true;
            this.Label_CurrentRequestCount.Location = new System.Drawing.Point(1108, 11);
            this.Label_CurrentRequestCount.Name = "Label_CurrentRequestCount";
            this.Label_CurrentRequestCount.Size = new System.Drawing.Size(11, 12);
            this.Label_CurrentRequestCount.TabIndex = 27;
            this.Label_CurrentRequestCount.Text = "0";
            this.Label_CurrentRequestCount.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "任务列表：";
            // 
            // Timer_GetIssue
            // 
            this.Timer_GetIssue.Interval = 1000;
            this.Timer_GetIssue.Tick += new System.EventHandler(this.Timer_GetIssue_Tick);
            // 
            // Button_RefreshIssue
            // 
            this.Button_RefreshIssue.Location = new System.Drawing.Point(93, 5);
            this.Button_RefreshIssue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_RefreshIssue.Name = "Button_RefreshIssue";
            this.Button_RefreshIssue.Size = new System.Drawing.Size(78, 22);
            this.Button_RefreshIssue.TabIndex = 30;
            this.Button_RefreshIssue.Text = "刷新通知";
            this.Button_RefreshIssue.UseVisualStyleBackColor = true;
            this.Button_RefreshIssue.Click += new System.EventHandler(this.Button_RefreshIssue_Click);
            // 
            // PictureBox_Loading
            // 
            this.PictureBox_Loading.Location = new System.Drawing.Point(908, 6);
            this.PictureBox_Loading.Name = "PictureBox_Loading";
            this.PictureBox_Loading.Size = new System.Drawing.Size(20, 21);
            this.PictureBox_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Loading.TabIndex = 29;
            this.PictureBox_Loading.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn2.FillWeight = 15F;
            this.dataGridViewTextBoxColumn2.HeaderText = "项目";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Subject";
            this.Column1.FillWeight = 35F;
            this.Column1.HeaderText = "任务";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 525;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.FillWeight = 15F;
            this.dataGridViewTextBoxColumn5.HeaderText = "注释";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // QuickControllButton
            // 
            this.QuickControllButton.DataPropertyName = "ButtonName";
            this.QuickControllButton.HeaderText = "操作";
            this.QuickControllButton.Name = "QuickControllButton";
            this.QuickControllButton.ReadOnly = true;
            this.QuickControllButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuickControllButton.Text = "按钮";
            this.QuickControllButton.Width = 95;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 411);
            this.Controls.Add(this.Button_RefreshIssue);
            this.Controls.Add(this.PictureBox_Loading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_CurrentRequestCount);
            this.Controls.Add(this.Label_CurrentRequestCountText);
            this.Controls.Add(this.Button_Today);
            this.Controls.Add(this.Button_WatcherList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridViewIssues);
            this.Controls.Add(this.LabelPercentText);
            this.Controls.Add(this.LabelPercent);
            this.Controls.Add(this.LabelTimeFootText);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelTimeHeadText);
            this.Controls.Add(this.PanelState);
            this.Controls.Add(this.Button_CopyLog);
            this.Controls.Add(this.LogOutputTextBox);
            this.Controls.Add(this.DataGridViewTimeEntry);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.Button_Logout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labor";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimeEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIssues)).EndInit();
            this.ContextMenuStripForNotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Logout;
        private System.Windows.Forms.Label Label_Info;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DataGridView DataGridViewTimeEntry;
        private System.Windows.Forms.TextBox LogOutputTextBox;
        private System.Windows.Forms.Button Button_CopyLog;
        private System.Windows.Forms.Panel PanelState;
        private System.Windows.Forms.Label LabelTimeHeadText;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelTimeFootText;
        private System.Windows.Forms.Label LabelPercent;
        private System.Windows.Forms.Label LabelPercentText;
        private System.Windows.Forms.DataGridView DataGridViewIssues;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Button_WatcherList;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripForNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.Button Button_Today;
        private System.Windows.Forms.Label Label_CurrentRequestCountText;
        private System.Windows.Forms.Label Label_CurrentRequestCount;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBox_Loading;
        private System.Windows.Forms.Timer Timer_GetIssue;
        private System.Windows.Forms.Button Button_RefreshIssue;
        private System.Windows.Forms.ToolStripMenuItem AutoStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewLinkColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewButtonColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn QuickControllButton;
    }
}

