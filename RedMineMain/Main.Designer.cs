
namespace RedMineEditer
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
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTemp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DingLogOutputTextBox = new System.Windows.Forms.TextBox();
            this.Button_CopyLog = new System.Windows.Forms.Button();
            this.Button_CopyTempLog = new System.Windows.Forms.Button();
            this.PanelState = new System.Windows.Forms.Panel();
            this.LabelTimeHeadText = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelTimeFootText = new System.Windows.Forms.Label();
            this.LabelPercent = new System.Windows.Forms.Label();
            this.LabelPercentText = new System.Windows.Forms.Label();
            this.DataGridViewIssues = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStripForNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Today = new System.Windows.Forms.Button();
            this.RadioButton_Code = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Label_CurrentRequestCountText = new System.Windows.Forms.Label();
            this.Label_CurrentRequestCount = new System.Windows.Forms.Label();
            this.Timer_Debug = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimeEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIssues)).BeginInit();
            this.ContextMenuStripForNotifyIcon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Logout
            // 
            this.Button_Logout.Location = new System.Drawing.Point(97, 8);
            this.Button_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(39, 16);
            this.Button_Logout.TabIndex = 0;
            this.Button_Logout.Text = "登出";
            this.Button_Logout.UseVisualStyleBackColor = true;
            this.Button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // Label_Info
            // 
            this.Label_Info.AutoSize = true;
            this.Label_Info.Location = new System.Drawing.Point(10, 11);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(41, 12);
            this.Label_Info.TabIndex = 1;
            this.Label_Info.Text = "用户名";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(555, 218);
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
            this.IsTemp,
            this.Comments,
            this.Percent,
            this.Hours});
            this.DataGridViewTimeEntry.Location = new System.Drawing.Point(10, 239);
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
            // IsTemp
            // 
            this.IsTemp.DataPropertyName = "IsTemp";
            this.IsTemp.FillWeight = 6F;
            this.IsTemp.HeaderText = "临时";
            this.IsTemp.Name = "IsTemp";
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
            // DingLogOutputTextBox
            // 
            this.DingLogOutputTextBox.Location = new System.Drawing.Point(770, 239);
            this.DingLogOutputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DingLogOutputTextBox.Multiline = true;
            this.DingLogOutputTextBox.Name = "DingLogOutputTextBox";
            this.DingLogOutputTextBox.ReadOnly = true;
            this.DingLogOutputTextBox.Size = new System.Drawing.Size(235, 108);
            this.DingLogOutputTextBox.TabIndex = 5;
            // 
            // Button_CopyLog
            // 
            this.Button_CopyLog.Location = new System.Drawing.Point(843, 218);
            this.Button_CopyLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_CopyLog.Name = "Button_CopyLog";
            this.Button_CopyLog.Size = new System.Drawing.Size(78, 20);
            this.Button_CopyLog.TabIndex = 6;
            this.Button_CopyLog.Text = "复制任务";
            this.Button_CopyLog.UseVisualStyleBackColor = true;
            this.Button_CopyLog.Click += new System.EventHandler(this.Button_CopyLog_Click);
            // 
            // Button_CopyTempLog
            // 
            this.Button_CopyTempLog.Location = new System.Drawing.Point(927, 218);
            this.Button_CopyTempLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_CopyTempLog.Name = "Button_CopyTempLog";
            this.Button_CopyTempLog.Size = new System.Drawing.Size(80, 20);
            this.Button_CopyTempLog.TabIndex = 7;
            this.Button_CopyTempLog.Text = "复制临时任务";
            this.Button_CopyTempLog.UseVisualStyleBackColor = true;
            this.Button_CopyTempLog.Click += new System.EventHandler(this.Button_CopyTempLog_Click);
            // 
            // PanelState
            // 
            this.PanelState.BackColor = System.Drawing.Color.Green;
            this.PanelState.Location = new System.Drawing.Point(697, 218);
            this.PanelState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelState.Name = "PanelState";
            this.PanelState.Size = new System.Drawing.Size(22, 16);
            this.PanelState.TabIndex = 8;
            // 
            // LabelTimeHeadText
            // 
            this.LabelTimeHeadText.AutoSize = true;
            this.LabelTimeHeadText.Location = new System.Drawing.Point(763, 220);
            this.LabelTimeHeadText.Name = "LabelTimeHeadText";
            this.LabelTimeHeadText.Size = new System.Drawing.Size(41, 12);
            this.LabelTimeHeadText.TabIndex = 9;
            this.LabelTimeHeadText.Text = "工时：";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(792, 220);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(29, 12);
            this.LabelTime.TabIndex = 10;
            this.LabelTime.Text = "00.0";
            // 
            // LabelTimeFootText
            // 
            this.LabelTimeFootText.AutoSize = true;
            this.LabelTimeFootText.Location = new System.Drawing.Point(816, 220);
            this.LabelTimeFootText.Name = "LabelTimeFootText";
            this.LabelTimeFootText.Size = new System.Drawing.Size(29, 12);
            this.LabelTimeFootText.TabIndex = 11;
            this.LabelTimeFootText.Text = "小时";
            // 
            // LabelPercent
            // 
            this.LabelPercent.AutoSize = true;
            this.LabelPercent.Location = new System.Drawing.Point(721, 220);
            this.LabelPercent.Name = "LabelPercent";
            this.LabelPercent.Size = new System.Drawing.Size(23, 12);
            this.LabelPercent.TabIndex = 12;
            this.LabelPercent.Text = "100";
            this.LabelPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPercentText
            // 
            this.LabelPercentText.AutoSize = true;
            this.LabelPercentText.Location = new System.Drawing.Point(741, 220);
            this.LabelPercentText.Name = "LabelPercentText";
            this.LabelPercentText.Size = new System.Drawing.Size(11, 12);
            this.LabelPercentText.TabIndex = 13;
            this.LabelPercentText.Text = "%";
            // 
            // DataGridViewIssues
            // 
            this.DataGridViewIssues.AllowUserToAddRows = false;
            this.DataGridViewIssues.AllowUserToDeleteRows = false;
            this.DataGridViewIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewIssues.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn6});
            this.DataGridViewIssues.Location = new System.Drawing.Point(10, 28);
            this.DataGridViewIssues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewIssues.Name = "DataGridViewIssues";
            this.DataGridViewIssues.ReadOnly = true;
            this.DataGridViewIssues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewIssues.RowHeadersVisible = false;
            this.DataGridViewIssues.RowTemplate.Height = 25;
            this.DataGridViewIssues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewIssues.Size = new System.Drawing.Size(754, 186);
            this.DataGridViewIssues.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn2.FillWeight = 15F;
            this.dataGridViewTextBoxColumn2.HeaderText = "项目";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectId";
            this.dataGridViewTextBoxColumn3.HeaderText = "SubjectId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn4.FillWeight = 19F;
            this.dataGridViewTextBoxColumn4.HeaderText = "任务";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsTemp";
            this.dataGridViewCheckBoxColumn1.FillWeight = 6F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "临时";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn5.FillWeight = 45F;
            this.dataGridViewTextBoxColumn5.HeaderText = "注释";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Percent";
            this.dataGridViewButtonColumn1.FillWeight = 6F;
            this.dataGridViewButtonColumn1.HeaderText = "%";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hours";
            this.dataGridViewTextBoxColumn6.FillWeight = 9F;
            this.dataGridViewTextBoxColumn6.HeaderText = "耗时";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 16);
            this.button1.TabIndex = 15;
            this.button1.Text = "新增Issue(未实现)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 8);
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
            this.button3.Location = new System.Drawing.Point(93, 218);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 20);
            this.button3.TabIndex = 18;
            this.button3.Text = "修改工时(未实现)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 218);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 20);
            this.button4.TabIndex = 17;
            this.button4.Text = "新增工时(未实现)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(452, 9);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(180, 16);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "只看未完成(不选择 最近7天)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(687, 8);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 16);
            this.button7.TabIndex = 21;
            this.button7.Text = "观察者(未实现)";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(569, 9);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 16);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "(未实现 观察者开关";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipTitle = "RedMine填写";
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStripForNotifyIcon;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "RedMineEditer";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // ContextMenuStripForNotifyIcon
            // 
            this.ContextMenuStripForNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quit});
            this.ContextMenuStripForNotifyIcon.Name = "ContextMenuStripForNotifyIcon";
            this.ContextMenuStripForNotifyIcon.ShowImageMargin = false;
            this.ContextMenuStripForNotifyIcon.Size = new System.Drawing.Size(156, 48);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(155, 22);
            this.Quit.Text = "退出";
            // 
            // Button_Today
            // 
            this.Button_Today.Location = new System.Drawing.Point(471, 218);
            this.Button_Today.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Today.Name = "Button_Today";
            this.Button_Today.Size = new System.Drawing.Size(78, 20);
            this.Button_Today.TabIndex = 23;
            this.Button_Today.Text = "选中今天";
            this.Button_Today.UseVisualStyleBackColor = true;
            this.Button_Today.Click += new System.EventHandler(this.Button_Today_Click);
            // 
            // RadioButton_Code
            // 
            this.RadioButton_Code.AutoSize = true;
            this.RadioButton_Code.Checked = true;
            this.RadioButton_Code.Location = new System.Drawing.Point(0, 1);
            this.RadioButton_Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButton_Code.Name = "RadioButton_Code";
            this.RadioButton_Code.Size = new System.Drawing.Size(71, 16);
            this.RadioButton_Code.TabIndex = 24;
            this.RadioButton_Code.TabStop = true;
            this.RadioButton_Code.Text = "开发任务";
            this.RadioButton_Code.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.RadioButton_Code);
            this.panel1.Location = new System.Drawing.Point(308, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 19);
            this.panel1.TabIndex = 25;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(69, 1);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 16);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.Text = "Bug任务";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Label_CurrentRequestCountText
            // 
            this.Label_CurrentRequestCountText.AutoSize = true;
            this.Label_CurrentRequestCountText.Location = new System.Drawing.Point(771, 10);
            this.Label_CurrentRequestCountText.Name = "Label_CurrentRequestCountText";
            this.Label_CurrentRequestCountText.Size = new System.Drawing.Size(77, 12);
            this.Label_CurrentRequestCountText.TabIndex = 26;
            this.Label_CurrentRequestCountText.Text = "当前请求数量";
            this.Label_CurrentRequestCountText.Visible = false;
            // 
            // Label_CurrentRequestCount
            // 
            this.Label_CurrentRequestCount.AutoSize = true;
            this.Label_CurrentRequestCount.Location = new System.Drawing.Point(855, 10);
            this.Label_CurrentRequestCount.Name = "Label_CurrentRequestCount";
            this.Label_CurrentRequestCount.Size = new System.Drawing.Size(11, 12);
            this.Label_CurrentRequestCount.TabIndex = 27;
            this.Label_CurrentRequestCount.Text = "0";
            this.Label_CurrentRequestCount.Visible = false;
            // 
            // Timer_Debug
            // 
            this.Timer_Debug.Tick += new System.EventHandler(this.Timer_Debug_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 354);
            this.Controls.Add(this.Label_CurrentRequestCount);
            this.Controls.Add(this.Label_CurrentRequestCountText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_Today);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.checkBox2);
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
            this.Controls.Add(this.Button_CopyTempLog);
            this.Controls.Add(this.Button_CopyLog);
            this.Controls.Add(this.DingLogOutputTextBox);
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
            this.Text = "RedMineEditer";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimeEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIssues)).EndInit();
            this.ContextMenuStripForNotifyIcon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Logout;
        private System.Windows.Forms.Label Label_Info;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DataGridView DataGridViewTimeEntry;
        private System.Windows.Forms.TextBox DingLogOutputTextBox;
        private System.Windows.Forms.Button Button_CopyLog;
        private System.Windows.Forms.Button Button_CopyTempLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewButtonColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.Panel PanelState;
        private System.Windows.Forms.Label LabelTimeHeadText;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelTimeFootText;
        private System.Windows.Forms.Label LabelPercent;
        private System.Windows.Forms.Label LabelPercentText;
        private System.Windows.Forms.DataGridView DataGridViewIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripForNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.Button Button_Today;
        private System.Windows.Forms.RadioButton RadioButton_Code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Label_CurrentRequestCountText;
        private System.Windows.Forms.Label Label_CurrentRequestCount;
        private System.Windows.Forms.Timer Timer_Debug;
    }
}

