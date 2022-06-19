
namespace Labor
{
    partial class LoginInfoEdit
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
            if(disposing && (components != null))
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
            this.TB_Host = new System.Windows.Forms.TextBox();
            this.Label_Account = new System.Windows.Forms.Label();
            this.Label_Host = new System.Windows.Forms.Label();
            this.TB_Account = new System.Windows.Forms.TextBox();
            this.TB_PassWord = new System.Windows.Forms.TextBox();
            this.Label_PassWord = new System.Windows.Forms.Label();
            this.TB_ApiKey = new System.Windows.Forms.TextBox();
            this.Label_ApiKey = new System.Windows.Forms.Label();
            this.Button_Sumbit = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Host
            // 
            this.TB_Host.Location = new System.Drawing.Point(87, 7);
            this.TB_Host.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Host.Name = "TB_Host";
            this.TB_Host.Size = new System.Drawing.Size(86, 21);
            this.TB_Host.TabIndex = 0;
            // 
            // Label_Account
            // 
            this.Label_Account.AutoSize = true;
            this.Label_Account.Location = new System.Drawing.Point(34, 42);
            this.Label_Account.Name = "Label_Account";
            this.Label_Account.Size = new System.Drawing.Size(47, 12);
            this.Label_Account.TabIndex = 1;
            this.Label_Account.Text = "登陆名:";
            // 
            // Label_Host
            // 
            this.Label_Host.AutoSize = true;
            this.Label_Host.Location = new System.Drawing.Point(4, 10);
            this.Label_Host.Name = "Label_Host";
            this.Label_Host.Size = new System.Drawing.Size(77, 12);
            this.Label_Host.TabIndex = 2;
            this.Label_Host.Text = "RedMine地址:";
            // 
            // TB_Account
            // 
            this.TB_Account.Location = new System.Drawing.Point(87, 39);
            this.TB_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Account.Name = "TB_Account";
            this.TB_Account.Size = new System.Drawing.Size(86, 21);
            this.TB_Account.TabIndex = 3;
            // 
            // TB_PassWord
            // 
            this.TB_PassWord.Location = new System.Drawing.Point(87, 64);
            this.TB_PassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PassWord.Name = "TB_PassWord";
            this.TB_PassWord.Size = new System.Drawing.Size(86, 21);
            this.TB_PassWord.TabIndex = 5;
            this.TB_PassWord.Enter += new System.EventHandler(this.TB_PassWord_Enter);
            this.TB_PassWord.Leave += new System.EventHandler(this.TB_PassWord_Leave);
            // 
            // Label_PassWord
            // 
            this.Label_PassWord.AutoSize = true;
            this.Label_PassWord.Location = new System.Drawing.Point(46, 67);
            this.Label_PassWord.Name = "Label_PassWord";
            this.Label_PassWord.Size = new System.Drawing.Size(35, 12);
            this.Label_PassWord.TabIndex = 4;
            this.Label_PassWord.Text = "密码:";
            // 
            // TB_ApiKey
            // 
            this.TB_ApiKey.Location = new System.Drawing.Point(87, 98);
            this.TB_ApiKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_ApiKey.Name = "TB_ApiKey";
            this.TB_ApiKey.Size = new System.Drawing.Size(86, 21);
            this.TB_ApiKey.TabIndex = 7;
            this.TB_ApiKey.Enter += new System.EventHandler(this.TB_ApiKey_Enter);
            this.TB_ApiKey.Leave += new System.EventHandler(this.TB_ApiKey_Leave);
            // 
            // Label_ApiKey
            // 
            this.Label_ApiKey.AutoSize = true;
            this.Label_ApiKey.Location = new System.Drawing.Point(4, 101);
            this.Label_ApiKey.Name = "Label_ApiKey";
            this.Label_ApiKey.Size = new System.Drawing.Size(83, 12);
            this.Label_ApiKey.TabIndex = 6;
            this.Label_ApiKey.Text = "ApiKey(推荐):";
            // 
            // Button_Sumbit
            // 
            this.Button_Sumbit.Location = new System.Drawing.Point(6, 123);
            this.Button_Sumbit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Sumbit.Name = "Button_Sumbit";
            this.Button_Sumbit.Size = new System.Drawing.Size(75, 20);
            this.Button_Sumbit.TabIndex = 8;
            this.Button_Sumbit.Text = "提交";
            this.Button_Sumbit.UseVisualStyleBackColor = true;
            this.Button_Sumbit.Click += new System.EventHandler(this.Button_Sumbit_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(90, 123);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(83, 20);
            this.Button_Exit.TabIndex = 9;
            this.Button_Exit.Text = "退出";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 1);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 1);
            this.label2.TabIndex = 11;
            // 
            // LoginInfoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Sumbit);
            this.Controls.Add(this.TB_ApiKey);
            this.Controls.Add(this.Label_ApiKey);
            this.Controls.Add(this.TB_PassWord);
            this.Controls.Add(this.Label_PassWord);
            this.Controls.Add(this.TB_Account);
            this.Controls.Add(this.Label_Host);
            this.Controls.Add(this.Label_Account);
            this.Controls.Add(this.TB_Host);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginInfoEdit";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "登录";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginInfoEdit_FormClosing);
            this.Load += new System.EventHandler(this.LoginInfoEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Host;
        private System.Windows.Forms.Label Label_Account;
        private System.Windows.Forms.Label Label_Host;
        private System.Windows.Forms.TextBox TB_Account;
        private System.Windows.Forms.TextBox TB_PassWord;
        private System.Windows.Forms.Label Label_PassWord;
        private System.Windows.Forms.TextBox TB_ApiKey;
        private System.Windows.Forms.Label Label_ApiKey;
        private System.Windows.Forms.Button Button_Sumbit;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}