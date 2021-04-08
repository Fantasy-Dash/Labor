
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
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DingLogOutputTextBox = new System.Windows.Forms.TextBox();
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
            this.dataGridViewTimeEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimeEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.Comments,
            this.Percent,
            this.Hours});
            this.dataGridViewTimeEntry.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewTimeEntry.Name = "dataGridViewTimeEntry";
            this.dataGridViewTimeEntry.ReadOnly = true;
            this.dataGridViewTimeEntry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTimeEntry.RowTemplate.Height = 25;
            this.dataGridViewTimeEntry.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTimeEntry.TabIndex = 4;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "项目";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "注释";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "Percent";
            this.Percent.HeaderText = "百分比";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            // 
            // Hours
            // 
            this.Hours.DataPropertyName = "Hours";
            this.Hours.HeaderText = "耗时";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            // 
            // DingLogOutputTextBox
            // 
            this.DingLogOutputTextBox.Location = new System.Drawing.Point(12, 198);
            this.DingLogOutputTextBox.Multiline = true;
            this.DingLogOutputTextBox.Name = "DingLogOutputTextBox";
            this.DingLogOutputTextBox.Size = new System.Drawing.Size(240, 110);
            this.DingLogOutputTextBox.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 368);
            this.Controls.Add(this.DingLogOutputTextBox);
            this.Controls.Add(this.dataGridViewTimeEntry);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.Button_Logout);
            this.Name = "Main";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.TextBox DingLogOutputTextBox;
    }
}

