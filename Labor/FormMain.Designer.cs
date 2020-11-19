
namespace Labor
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbP = new System.Windows.Forms.ComboBox();
            this.tbAR = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTask = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(433, 481);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 100;
            this.btnSubmit.Text = "复制";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbText.Location = new System.Drawing.Point(12, 40);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(596, 23);
            this.tbText.TabIndex = 1;
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxState.Location = new System.Drawing.Point(421, 381);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(204, 80);
            this.textBoxState.TabIndex = 997;
            this.textBoxState.Visible = false;
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Location = new System.Drawing.Point(421, 359);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(204, 16);
            this.cbD.TabIndex = 3;
            this.cbD.Text = "粘贴钉钉后自动拆分单条到剪贴板";
            this.cbD.UseVisualStyleBackColor = true;
            this.cbD.Visible = false;
            // 
            // cbP
            // 
            this.cbP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbP.FormattingEnabled = true;
            this.cbP.Location = new System.Drawing.Point(12, 12);
            this.cbP.Name = "cbP";
            this.cbP.Size = new System.Drawing.Size(646, 22);
            this.cbP.TabIndex = 0;
            // 
            // tbAR
            // 
            this.tbAR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAR.Location = new System.Drawing.Point(12, 303);
            this.tbAR.Multiline = true;
            this.tbAR.Name = "tbAR";
            this.tbAR.ReadOnly = true;
            this.tbAR.Size = new System.Drawing.Size(403, 279);
            this.tbAR.TabIndex = 998;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(614, 40);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(44, 23);
            this.btnOk.TabIndex = 999;
            this.btnOk.Text = "提交";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(591, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 23);
            this.btnDelete.TabIndex = 1000;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lbTask
            // 
            this.lbTask.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTask.FormattingEnabled = true;
            this.lbTask.ItemHeight = 14;
            this.lbTask.Location = new System.Drawing.Point(12, 69);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(646, 228);
            this.lbTask.TabIndex = 1001;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1002;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbAR);
            this.Controls.Add(this.cbP);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnSubmit);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.ComboBox cbP;
        private System.Windows.Forms.TextBox tbAR;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbTask;
        private System.Windows.Forms.Button button1;
    }
}

