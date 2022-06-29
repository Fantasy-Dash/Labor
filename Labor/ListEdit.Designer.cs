namespace Labor
{
    partial class ListEdit
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
            this.ListBox_Data = new System.Windows.Forms.ListBox();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListBox_Data
            // 
            this.ListBox_Data.FormattingEnabled = true;
            this.ListBox_Data.ItemHeight = 12;
            this.ListBox_Data.Location = new System.Drawing.Point(12, 12);
            this.ListBox_Data.Name = "ListBox_Data";
            this.ListBox_Data.Size = new System.Drawing.Size(120, 88);
            this.ListBox_Data.TabIndex = 0;
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(138, 12);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 1;
            this.Button_Delete.Text = "删除";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(138, 104);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "新增";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.Location = new System.Drawing.Point(12, 106);
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.Size = new System.Drawing.Size(120, 21);
            this.TextBox_Input.TabIndex = 3;
            // 
            // ListEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 136);
            this.Controls.Add(this.TextBox_Input);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.ListBox_Data);
            this.Name = "ListEdit";
            this.Text = "输入Id";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListEdit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Data;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.TextBox TextBox_Input;
    }
}