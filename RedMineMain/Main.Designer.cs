
namespace RedMineMain
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimeEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Logout
            // 
            this.Button_Logout.Location = new System.Drawing.Point(135, 12);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(75, 23);
            this.Button_Logout.TabIndex = 0;
            this.Button_Logout.Text = "登出";
            this.Button_Logout.UseVisualStyleBackColor = true;
            this.Button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // Label_Info
            // 
            this.Label_Info.AutoSize = true;
            this.Label_Info.Location = new System.Drawing.Point(12, 15);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(44, 17);
            this.Label_Info.TabIndex = 1;
            this.Label_Info.Text = "用户名";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(231, 12);
            this.DateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(161, 23);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.Value = new System.DateTime(2021, 4, 24, 23, 59, 59, 0);
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
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
            this.DataGridViewTimeEntry.Location = new System.Drawing.Point(12, 41);
            this.DataGridViewTimeEntry.Name = "DataGridViewTimeEntry";
            this.DataGridViewTimeEntry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewTimeEntry.RowHeadersVisible = false;
            this.DataGridViewTimeEntry.RowTemplate.Height = 25;
            this.DataGridViewTimeEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewTimeEntry.Size = new System.Drawing.Size(880, 151);
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
            this.DingLogOutputTextBox.Location = new System.Drawing.Point(12, 198);
            this.DingLogOutputTextBox.Multiline = true;
            this.DingLogOutputTextBox.Name = "DingLogOutputTextBox";
            this.DingLogOutputTextBox.Size = new System.Drawing.Size(279, 322);
            this.DingLogOutputTextBox.TabIndex = 5;
            // 
            // Button_CopyLog
            // 
            this.Button_CopyLog.Location = new System.Drawing.Point(12, 526);
            this.Button_CopyLog.Name = "Button_CopyLog";
            this.Button_CopyLog.Size = new System.Drawing.Size(75, 23);
            this.Button_CopyLog.TabIndex = 6;
            this.Button_CopyLog.Text = "复制任务";
            this.Button_CopyLog.UseVisualStyleBackColor = true;
            this.Button_CopyLog.Click += new System.EventHandler(this.Button_CopyLog_Click);
            // 
            // Button_CopyTempLog
            // 
            this.Button_CopyTempLog.Location = new System.Drawing.Point(93, 526);
            this.Button_CopyTempLog.Name = "Button_CopyTempLog";
            this.Button_CopyTempLog.Size = new System.Drawing.Size(91, 23);
            this.Button_CopyTempLog.TabIndex = 7;
            this.Button_CopyTempLog.Text = "复制临时任务";
            this.Button_CopyTempLog.UseVisualStyleBackColor = true;
            this.Button_CopyTempLog.Click += new System.EventHandler(this.Button_CopyTempLog_Click);
            // 
            // PanelState
            // 
            this.PanelState.BackColor = System.Drawing.Color.Green;
            this.PanelState.Location = new System.Drawing.Point(398, 12);
            this.PanelState.Name = "PanelState";
            this.PanelState.Size = new System.Drawing.Size(26, 23);
            this.PanelState.TabIndex = 8;
            // 
            // LabelTimeHeadText
            // 
            this.LabelTimeHeadText.AutoSize = true;
            this.LabelTimeHeadText.Location = new System.Drawing.Point(479, 15);
            this.LabelTimeHeadText.Name = "LabelTimeHeadText";
            this.LabelTimeHeadText.Size = new System.Drawing.Size(44, 17);
            this.LabelTimeHeadText.TabIndex = 9;
            this.LabelTimeHeadText.Text = "工时：";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(513, 15);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(32, 17);
            this.LabelTime.TabIndex = 10;
            this.LabelTime.Text = "00.0";
            // 
            // LabelTimeFootText
            // 
            this.LabelTimeFootText.AutoSize = true;
            this.LabelTimeFootText.Location = new System.Drawing.Point(541, 15);
            this.LabelTimeFootText.Name = "LabelTimeFootText";
            this.LabelTimeFootText.Size = new System.Drawing.Size(32, 17);
            this.LabelTimeFootText.TabIndex = 11;
            this.LabelTimeFootText.Text = "小时";
            // 
            // LabelPercent
            // 
            this.LabelPercent.AutoSize = true;
            this.LabelPercent.Location = new System.Drawing.Point(430, 15);
            this.LabelPercent.Name = "LabelPercent";
            this.LabelPercent.Size = new System.Drawing.Size(29, 17);
            this.LabelPercent.TabIndex = 12;
            this.LabelPercent.Text = "100";
            this.LabelPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPercentText
            // 
            this.LabelPercentText.AutoSize = true;
            this.LabelPercentText.Location = new System.Drawing.Point(454, 15);
            this.LabelPercentText.Name = "LabelPercentText";
            this.LabelPercentText.Size = new System.Drawing.Size(19, 17);
            this.LabelPercentText.TabIndex = 13;
            this.LabelPercentText.Text = "%";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 561);
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
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimeEntry)).EndInit();
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
    }
}

