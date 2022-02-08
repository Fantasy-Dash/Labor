using RedMineEditer.Properties;
using System.Windows.Forms;

namespace RedMineEditer
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
            Settings.Default.RedMineHost = TB_Host.Text;
            Settings.Default.Account = TB_Account.Text;
            Settings.Default.Password = TB_PassWord.Text;
            Settings.Default.ApiKey = TB_ApiKey.Text;
            Settings.Default.Save();
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void TB_PassWord_Enter(object sender, System.EventArgs e) => TB_PassWord.PasswordChar = char.MinValue;

        private void TB_PassWord_Leave(object sender, System.EventArgs e) => TB_PassWord.PasswordChar = '*';

        private void Button_Exit_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoginInfoEdit_Load(object sender, System.EventArgs e)
        {
            TB_Host.Text = Settings.Default.RedMineHost;
            TB_Account.Text = Settings.Default.Account;
            TB_PassWord.Text = Settings.Default.Password;
            TB_ApiKey.Text = Settings.Default.ApiKey;
        }
    }
}
