using System.Windows.Forms;

namespace RedMine
{
    public partial class LoginInfoEdit : Form
    {
        public LoginInfoEdit() => InitializeComponent();

        private void Button_Sumbit_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.RedMineHost = TB_Host.Text;
            Properties.Settings.Default.Account = TB_Account.Text;
            Properties.Settings.Default.Password = TB_PassWord.Text;
            Properties.Settings.Default.ApiKey = TB_ApiKey.Text;
            Close();
        }

        private void TB_PassWord_Enter(object sender, System.EventArgs e) => TB_PassWord.PasswordChar = char.MinValue;

        private void TB_PassWord_Leave(object sender, System.EventArgs e) => TB_PassWord.PasswordChar = '*';

        private void Button_Exit_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.Save();
            System.Environment.Exit(0);
        }

        private void LoginInfoEdit_Load(object sender, System.EventArgs e)
        {
            TB_Host.Text = Properties.Settings.Default.RedMineHost;
            TB_Account.Text = Properties.Settings.Default.Account;
            TB_PassWord.Text = Properties.Settings.Default.Password;
            TB_ApiKey.Text = Properties.Settings.Default.ApiKey;
        }
    }
}
