using Labor.Properties;
using System;
using System.Windows.Forms;

namespace Labor
{
    public partial class LoginInfoEdit : Form
    {
        public LoginInfoEdit() => InitializeComponent();

        private void Button_Sumbit_Click(object sender, System.EventArgs e)
        {
            if (!TB_Host.Text.StartsWith("http://"))
            {
                if (TB_Host.Text.StartsWith("https://"))
                {
                    TB_Host.Text = TB_Host.Text.Replace("https://", "http://");
                }
                else
                {
                    TB_Host.Text = "http://" + TB_Host.Text;
                }
            }
            if (!TB_Host.Text.EndsWith("/"))
            {
                TB_Host.Text += "/";
            }
            Settings.Default.RedMineHost = TB_Host.Text;
            Settings.Default.Account = TB_Account.Text;
            Settings.Default.Password = TB_PassWord.Text;
            Settings.Default.ApiKey = TB_ApiKey.Text;
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void TB_PassWord_Enter(object sender, EventArgs e) => TB_PassWord.PasswordChar = char.MinValue;
        private void TB_ApiKey_Enter(object sender, EventArgs e) => TB_ApiKey.PasswordChar = char.MinValue;

        private void TB_PassWord_Leave(object sender, EventArgs e) => TB_PassWord.PasswordChar = '*';
        private void TB_ApiKey_Leave(object sender, EventArgs e) => TB_ApiKey.PasswordChar = '*';

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginInfoEdit_Load(object sender, EventArgs e)
        {
            TB_Host.Text = Settings.Default.RedMineHost;
            TB_Account.Text = Settings.Default.Account;
            TB_PassWord.Text = Settings.Default.Password;
            TB_ApiKey.Text = Settings.Default.ApiKey;
            Settings.Default.IsLogout = true;
        }

        private void LoginInfoEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗体时规范化窗体返回值
            if (DialogResult != DialogResult.Yes && DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
