using Labor.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Labor
{
    /// <summary>
    /// LoginInfoEdit.xaml 的交互逻辑
    /// </summary>
    public partial class LoginInfoEdit : Window
    {
        public LoginInfoEdit()
        {
            InitializeComponent();
        }

        private void Button_Sumbit_Click(object sender, RoutedEventArgs e)
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
            DialogResult = true;
            Close();
        }

        private void TB_PassWord_GotFocus(object sender, RoutedEventArgs e) => TB_PassWord.PasswordChar = char.MinValue;

        private void TB_ApiKey_GotFocus(object sender, RoutedEventArgs e) => TB_ApiKey.PasswordChar = char.MinValue;

        private void TB_PassWord_LostFocus(object sender, RoutedEventArgs e) => TB_PassWord.PasswordChar = '*';

        private void TB_ApiKey_LostFocus(object sender, RoutedEventArgs e) => TB_ApiKey.PasswordChar = '*';

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TB_Host.Text = Settings.Default.RedMineHost;
            TB_Account.Text = Settings.Default.Account;
            TB_PassWord.Text = Settings.Default.Password;
            TB_ApiKey.Text = Settings.Default.ApiKey;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DialogResult != true)
            {
                DialogResult = false;
            }
        }
    }
}
