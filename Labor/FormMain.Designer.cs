
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
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbP = new System.Windows.Forms.ComboBox();
            this.tbAR = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTask = new System.Windows.Forms.ListBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.tbPst = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btnSelectClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(463, 481);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 100;
            this.btnSubmit.Text = "复制";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // tbSummary
            // 
            this.tbSummary.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSummary.Location = new System.Drawing.Point(12, 40);
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(446, 23);
            this.tbSummary.TabIndex = 1;
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxState.Location = new System.Drawing.Point(463, 381);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(204, 80);
            this.textBoxState.TabIndex = 997;
            this.textBoxState.Visible = false;
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Location = new System.Drawing.Point(463, 359);
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
            this.cbP.Size = new System.Drawing.Size(286, 22);
            this.cbP.TabIndex = 0;
            // 
            // tbAR
            // 
            this.tbAR.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAR.Location = new System.Drawing.Point(12, 359);
            this.tbAR.Multiline = true;
            this.tbAR.Name = "tbAR";
            this.tbAR.ReadOnly = true;
            this.tbAR.Size = new System.Drawing.Size(446, 230);
            this.tbAR.TabIndex = 998;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("宋体", 9F);
            this.btnOk.Location = new System.Drawing.Point(304, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(68, 23);
            this.btnOk.TabIndex = 999;
            this.btnOk.Text = "提交";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 22);
            this.btnDelete.TabIndex = 1000;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lbTask
            // 
            this.lbTask.AllowDrop = true;
            this.lbTask.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTask.FormattingEnabled = true;
            this.lbTask.ItemHeight = 14;
            this.lbTask.Location = new System.Drawing.Point(12, 96);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(446, 228);
            this.lbTask.TabIndex = 1001;
            this.lbTask.SelectedIndexChanged += new System.EventHandler(this.LbTask_SelectedIndexChanged);
            this.lbTask.DragDrop += new System.Windows.Forms.DragEventHandler(this.LbTask_DragDrop);
            this.lbTask.DragOver += new System.Windows.Forms.DragEventHandler(this.LbTask_DragOver);
            this.lbTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LbTask_MouseDown);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(463, 510);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 1002;
            this.btnSetting.Text = "设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblTime.Location = new System.Drawing.Point(301, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(84, 14);
            this.lblTime.TabIndex = 1003;
            this.lblTime.Text = "总计0.0小时";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(392, 12);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(67, 22);
            this.btnSort.TabIndex = 1004;
            this.btnSort.Text = "排序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // tbPst
            // 
            this.tbPst.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPst.Location = new System.Drawing.Point(12, 67);
            this.tbPst.Name = "tbPst";
            this.tbPst.Size = new System.Drawing.Size(161, 23);
            this.tbPst.TabIndex = 2;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTime.Location = new System.Drawing.Point(179, 67);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(119, 23);
            this.tbTime.TabIndex = 3;
            // 
            // btnSelectClear
            // 
            this.btnSelectClear.Location = new System.Drawing.Point(391, 67);
            this.btnSelectClear.Name = "btnSelectClear";
            this.btnSelectClear.Size = new System.Drawing.Size(67, 23);
            this.btnSelectClear.TabIndex = 1005;
            this.btnSelectClear.Text = "清除选中";
            this.btnSelectClear.UseVisualStyleBackColor = true;
            this.btnSelectClear.Click += new System.EventHandler(this.BtnSelectClear_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 599);
            this.Controls.Add(this.btnSelectClear);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbPst);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbAR);
            this.Controls.Add(this.cbP);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.tbSummary);
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
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.ComboBox cbP;
        private System.Windows.Forms.TextBox tbAR;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbTask;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox tbPst;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btnSelectClear;
    }
}

