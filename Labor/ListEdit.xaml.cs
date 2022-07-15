using System.Windows;

namespace Labor
{
    /// <summary>
    /// ListEdit.xaml 的交互逻辑
    /// </summary>
    public partial class ListEdit : Window
    {
        public ListEdit()
        {
            InitializeComponent();
            foreach (var item in MainWindow.watcherList)
            {
                ListBox_Data.Items.Add(item);
            }
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox_Data.SelectedIndex > -1)
            {
                ListBox_Data.Items.Remove(ListBox_Data.SelectedIndex);
            }
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Input.Text != string.Empty)
            {
                ListBox_Data.Items.Add(int.Parse(TextBox_Input.Text).ToString());
                TextBox_Input.Text = string.Empty;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.watcherList.Clear();
            foreach (var item in ListBox_Data.Items)
            {
                MainWindow.watcherList.Add(item.ToString());
            }
        }
    }
}
