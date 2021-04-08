using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using Redmine.Net.Api;
using Redmine.Net.Api.Extensions;
using Redmine.Net.Api.Types;
using RedMine;
using RedMine.Model;
using RedMine.Properties;

namespace RedMineMain
{
    public partial class Main : Form
    {
        RedmineManager manager=null;

        public Main() => InitializeComponent();

        private void Main_Load(object sender, EventArgs e)
        {
            Login();
            DateTimePicker.Value = DateTime.Today;
            DateTimePicker.MaxDate = DateTime.Today;
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            new LoginInfoEdit().ShowDialog();
            Main_Load(sender, e);
        }

        public void Login()
        {
relogin:
            var host=Settings.Default.RedMineHost;
            var account=Settings.Default.Account;
            var passWord=Settings.Default.Password;
            var apiKey=Settings.Default.ApiKey;
            if(!apiKey.IsNullOrWhiteSpace())
            {
                manager = new(host, apiKey);
            }
            else if(!account.IsNullOrWhiteSpace())
            {
                manager = new(host, account, passWord);
            }
            if(manager is null) goto relogin;
            User currUser;
            try
            {
                currUser = manager.GetCurrentUser();
            }
            catch { new LoginInfoEdit().ShowDialog(); goto relogin; }
            Label_Info.Text = currUser.FirstName + " " + currUser.LastName;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ReloadTimeEntry();
        }

        private void ReloadTimeEntry()
        {
            var param = new NameValueCollection
            {
                { RedmineKeys.USER_ID, $"=me" },
                { RedmineKeys.SPENT_ON, $"={DateTimePicker.Value:yyyy-MM-dd}" },
                { RedmineKeys.SORT,"project" }
            };
            var timeEntryList= manager.GetObjects<TimeEntry>(param);
            if(timeEntryList is null)
            {
                timeEntryList = new();
            }
            List<TimeEntryModel> timeEntryModelList=new();
            timeEntryList.ForEach(row =>
            {
                var issue= manager.GetObject<Issue>(row.Issue.Id.ToString(),new NameValueCollection());
                timeEntryModelList.Add(new()
                {
                    ProjectName = row.Project.Name,
                    Hours = row.Hours,
                    Percent = issue.DoneRatio,
                    Comments = row.Comments,
                });
            });
            dataGridViewTimeEntry.DataSource = timeEntryModelList;
            DingLogOutputRefresh(timeEntryModelList);
            GC.Collect();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            DateTimePicker.MaxDate = DateTime.Today;
            ReloadTimeEntry();
        }

        private void DingLogOutputRefresh(List<TimeEntryModel> timeEntryModelList)
        {
            DingLogOutputTextBox.Text = "";
            string strTempProject="";
            int projectTaskCount=0;
            foreach(TimeEntryModel task in timeEntryModelList)
            {
                if(task.ProjectName == strTempProject)
                {
                    projectTaskCount += 1;
                    PrintTaskToTBAR(task, projectTaskCount);
                }
                else
                {
                    if(DingLogOutputTextBox.Text == "")
                    {
                        DingLogOutputTextBox.Text += "【" + task.ProjectName + "】\r\n";
                    }
                    else
                    {
                        DingLogOutputTextBox.Text += "\r\n【" + task.ProjectName + "】\r\n";
                    }
                    projectTaskCount = 1;
                    PrintTaskToTBAR(task, projectTaskCount);
                    strTempProject = task.ProjectName;
                }
            }
            DingLogOutputTextBox.Text = DingLogOutputTextBox.Text.Trim();
        }

        private void PrintTaskToTBAR(TimeEntryModel task, int taskcount) => DingLogOutputTextBox.Text += taskcount + "、" + task.Comments + "（" + task.Percent + "%，" + task.Hours + "h）\r\n";
    }
}
