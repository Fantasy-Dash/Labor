
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
            this.dataGridViewTimeEntry = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeEntry)).BeginInit();
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
            // dataGridViewTimeEntry
            // 
            this.dataGridViewTimeEntry.AllowUserToAddRows = false;
            this.dataGridViewTimeEntry.AllowUserToDeleteRows = false;
            this.dataGridViewTimeEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimeEntry.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTimeEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimeEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProjectName,
            this.SubjectId,
            this.Subject,
            this.IsTemp,
            this.Comments,
            this.Percent,
            this.Hours});
            this.dataGridViewTimeEntry.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewTimeEntry.Name = "dataGridViewTimeEntry";
            this.dataGridViewTimeEntry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTimeEntry.RowHeadersVisible = false;
            this.dataGridViewTimeEntry.RowTemplate.Height = 25;
            this.dataGridViewTimeEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTimeEntry.Size = new System.Drawing.Size(880, 151);
            this.dataGridViewTimeEntry.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.FillWeight = 15F;
            this.ProjectName.HeaderText = "项目";
            this.ProjectName.Name = "ProjectName";
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.HeaderText = "SubjectId";
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.Visible = false;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.FillWeight = 19F;
            this.Subject.HeaderText = "任务";
            this.Subject.Name = "Subject";
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
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "Percent";
            this.Percent.FillWeight = 6F;
            this.Percent.HeaderText = "%";
            this.Percent.Name = "Percent";
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "Hours";
            this.Hours.FillWeight = 9F;
            this.Hours.HeaderText = "耗时";
            this.Hours.Name = "Hours";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.Button_CopyTempLog);
            this.Controls.Add(this.Button_CopyLog);
            this.Controls.Add(this.DingLogOutputTextBox);
            this.Controls.Add(this.dataGridViewTimeEntry);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Logout;
        private System.Windows.Forms.Label Label_Info;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DataGridView dataGridViewTimeEntry;
        private System.Windows.Forms.TextBox DingLogOutputTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewButtonColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.Button Button_CopyLog;
        private System.Windows.Forms.Button Button_CopyTempLog;
    }
}

