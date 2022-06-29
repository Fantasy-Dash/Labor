using Labor.Properties;
using System;
using System.Windows.Forms;

namespace Labor
{
    public partial class ListEdit : Form
    {

        public ListEdit()
        {
            InitializeComponent();
            foreach(var item in Main.watcherList)
            {
                ListBox_Data.Items.Add(item);
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text != string.Empty)
            {
                ListBox_Data.Items.Add(int.Parse(TextBox_Input.Text).ToString());
                TextBox_Input.Text = string.Empty;
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (ListBox_Data.SelectedIndex > -1)
            {
                ListBox_Data.Items.Remove(ListBox_Data.SelectedIndex);
            }
        }

        private void ListEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.watcherList.Clear();
            foreach (var item in ListBox_Data.Items)
            {
                Main.watcherList.Add(item.ToString());
            }
        }
    }
}
