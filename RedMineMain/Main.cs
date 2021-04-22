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
        string DingLogText=string.Empty;
        string DingTempLogText=string.Empty;

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
                if(issue.Subject.IndexOf("【临时】") > -1)
                {
                    timeEntryModelList.Add(new()
                    {
                        Id = row.Id,
                        ProjectName = row.Project.Name[(row.Project.Name.IndexOf('】') + 1)..],
                        SubjectId = issue.Id,
                        Subject = issue.Subject.Replace("【临时】", string.Empty),
                        Hours = row.Hours,
                        Percent = issue.DoneRatio,
                        Comments = row.Comments,
                        IsTemp = true,
                    });
                }
                else
                {
                    timeEntryModelList.Add(new()
                    {
                        Id = row.Id,
                        ProjectName = row.Project.Name[(row.Project.Name.IndexOf('】') + 1)..],
                        SubjectId = issue.Id,
                        Subject = issue.Subject,
                        Hours = row.Hours,
                        Percent = issue.DoneRatio,
                        Comments = row.Comments,
                        IsTemp = false,
                    });
                }

            });
            DingLogOutputRefresh(timeEntryModelList);
            dataGridViewTimeEntry.DataSource = timeEntryModelList;
            GC.Collect();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            DateTimePicker.MaxDate = DateTime.Today;
            ReloadTimeEntry();
        }

        private void DingLogOutputRefresh(List<TimeEntryModel> timeEntryModelList)
        {
            string strTempProject=string.Empty;
            int projectTaskCount=0;
            List<TimeEntryModel> tempTimeEntryModelList=new();
            DingLogText = string.Empty;
            foreach(TimeEntryModel task in timeEntryModelList)
            {
                if(!task.IsTemp)
                {
                    DrawText(ref DingLogText, task, ref strTempProject, ref projectTaskCount);
                }
                else
                {
                    tempTimeEntryModelList.Add(task);
                }
            }
            DingTempLogText = string.Empty;
            foreach(TimeEntryModel task in tempTimeEntryModelList)
            {
                DrawText(ref DingTempLogText, task, ref strTempProject, ref projectTaskCount);
            }
            DingLogOutputTextBox.Text = (DingLogText + "\r\n----------临时任务----------\r\n\r\n" + DingTempLogText).TrimEnd('\n').TrimEnd('\r');
        }

        private void DrawText(ref string logText, TimeEntryModel task, ref string strTempProject, ref int projectTaskCount)
        {
            if(task.ProjectName == strTempProject)
            {
                projectTaskCount += 1;
                logText += projectTaskCount + "、" + task.Comments + "（" + task.Percent + "%，" + task.Hours + "h）\r\n";
            }
            else
            {
                if(logText == string.Empty)
                {
                    logText += "【" + task.ProjectName + "】\r\n";
                }
                else
                {
                    logText += "\r\n【" + task.ProjectName + "】\r\n";
                }
                projectTaskCount = 1;
                logText += projectTaskCount + "、" + task.Comments + "（" + task.Percent + "%，" + task.Hours + "h）\r\n";
                strTempProject = task.ProjectName;
            }
        }

        private void Button_CopyLog_Click(object sender, EventArgs e) => Clipboard.SetText(DingLogText.Replace("\r\n", "\n").TrimEnd('\n'));

        private void Button_CopyTempLog_Click(object sender, EventArgs e) => Clipboard.SetText(DingTempLogText.Replace("\r\n", "\n").TrimEnd('\n'));
    }
}
