using Redmine.Net.Api.Types;
using RedMineEditer.Manager;
using RedMineEditer.Model;
using RedMineEditer.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedMineEditer
{
    public partial class Main : Form
    {
        string DingLogText = string.Empty;
        string DingTempLogText = string.Empty;
        TimeEntryManager timeEntryManager = new TimeEntryManager();
        IssueManager issueManager = new IssueManager();
        List<TimeEntryModel> TimeEntryModelList = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
#if DEBUG
            Label_CurrentRequestCountText.Visible = true;
            Label_CurrentRequestCount.Visible = true;
            Timer_Debug.Enabled = true;
#endif
            #region Config
            Settings.Default.ConfigVersion=
           if (==) 
            #endregion
            Login();
            ContextMenuStripForNotifyIcon.ItemClicked += new ToolStripItemClickedEventHandler(ToolStripItemForNotifyIcon_Click);
            DateTimePicker.MaxDate = DateTime.Today;
            DateTimePicker.Value = DateTime.Today;
        }

        private void Login()
        {
            User CurrentUser = issueManager.Login();
            Label_Info.Text = CurrentUser.FirstName + " " + CurrentUser.LastName;
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        public void Logout()
        {
            Visible = false;
            var ret = new LoginInfoEdit().ShowDialog();
            if (ret == DialogResult.Cancel) { ProgramEnd(); }
            Login();
            Visible = true;
        }

        public void ProgramEnd()
        {
            NotifyIcon.Visible = false;//避免关闭程序后右下角图标滞留
            Environment.Exit(0);
        }

        private void DateTimePicker_CloseUp(object sender, EventArgs e) => _ = ReloadTimeEntry();

        private async Task<bool> ReloadTimeEntry()
        {
            return await Task.Run(() =>
            {
                var param = new NameValueCollection
                {
                        { Redmine.Net.Api.RedmineKeys.USER_ID, $"=me" },
                        { Redmine.Net.Api.RedmineKeys.SPENT_ON, $"={DateTimePicker.Value:yyyy-MM-dd}" },
                        { Redmine.Net.Api.RedmineKeys.SORT,"project" }
                };
                var timeEntryList = timeEntryManager.GetList(param);
                if (timeEntryList is null)
                {
                    timeEntryList = new List<TimeEntry>();
                }
                TimeEntryModelList = new List<TimeEntryModel>();
                timeEntryList.ForEach(row =>
                {
                    var issue = issueManager.Get(row.Issue.Id.ToString(), new NameValueCollection());
                    TimeEntryModel tEM = new TimeEntryModel()
                    {
                        Id = row.Id,
                        ProjectName = row.Project.Name.Substring((row.Project.Name.IndexOf('】') + 1)),
                        SubjectId = issue.Id,
                        Hours = row.Hours,
                        Percent = issue.DoneRatio,
                        Comments = row.Comments,
                    };
                    if (issue.Subject.IndexOf("【临时】") > -1)
                    {
                        tEM.Subject = issue.Subject.Replace("【临时】", string.Empty);
                        tEM.IsTemp = true;
                        TimeEntryModelList.Add(tEM);
                    }
                    else
                    {
                        tEM.Subject = issue.Subject;
                        tEM.IsTemp = false;
                        TimeEntryModelList.Add(tEM);
                    }
                });
                new Thread(() =>
                {
                    Action action = () =>
                    {
                        DataGridViewTimeEntry.DataSource = new List<TimeEntryModel>(TimeEntryModelList.Select(row => (TimeEntryModel)row.Clone()));
                        DingLogOutputRefresh();
                        ChangePanelState();
                        GC.Collect();
                    };
                    Invoke(action);
                })
                { IsBackground = true }.Start();
                return true;
            });
        }

        private async void Main_Activated(object sender, EventArgs e)
        {
            DateTimePicker.MaxDate = DateTime.Today;
            _ = await ReloadTimeEntry();
        }

        private void ChangePanelState()
        {
            var avgPercent = Math.Round((TimeEntryModelList.Sum(row => row.Percent) / (TimeEntryModelList.Count == 0 ? 1 : TimeEntryModelList.Count)).Value);
            LabelPercent.Text = avgPercent.ToString();
            var totalTime = TimeEntryModelList.Sum(row => row.Hours);
            LabelTime.Text = totalTime.ToString();
            PanelState.BackColor = avgPercent != 100 || totalTime < 8 ? Color.Yellow : Color.Green;
            PanelState.BackColor = avgPercent != 100 && totalTime < 8 ? Color.Red : PanelState.BackColor;
        }

        private void DingLogOutputRefresh()
        {
            string strTempProject = string.Empty;
            int projectTaskCount = 0;
            List<TimeEntryModel> tempTimeEntryModelList = new List<TimeEntryModel>();
            DingLogText = string.Empty;
            foreach (TimeEntryModel task in TimeEntryModelList)
            {
                if (!task.IsTemp)
                {
                    DrawText(ref DingLogText, task, ref strTempProject, ref projectTaskCount);
                }
                else
                {
                    tempTimeEntryModelList.Add(task);
                }
            }
            DingTempLogText = string.Empty;
            strTempProject = string.Empty;
            projectTaskCount = 0;
            foreach (TimeEntryModel task in tempTimeEntryModelList)
            {
                DrawText(ref DingTempLogText, task, ref strTempProject, ref projectTaskCount);
            }
            DingLogOutputTextBox.Text = (DingLogText + "\r\n----------临时任务----------\r\n\r\n" + DingTempLogText).TrimEnd('\n').TrimEnd('\r');
        }

        private static void DrawText(ref string logText, TimeEntryModel task, ref string strTempProject, ref int projectTaskCount)
        {
            if (task.ProjectName == strTempProject)
            {
                projectTaskCount += 1;
                logText += projectTaskCount + "、" + task.Comments + "（" + task.Percent + "%，" + task.Hours + "h）\r\n";
            }
            else
            {
                if (logText == string.Empty)
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

        private void Button_CopyLog_Click(object sender, EventArgs e)
        {
            if (!CheckCompletionAndTime()) return;
            if (!DingLogText.IsNullOrEmpty())
            {
                Clipboard.SetText(DingLogText.Replace("\r\n", "\n").TrimEnd('\n'));
            }
            else
            {
                Clipboard.SetText("");
            }
        }

        private void Button_CopyTempLog_Click(object sender, EventArgs e)
        {
            if (!CheckCompletionAndTime()) return;
            if (!DingTempLogText.IsNullOrEmpty())
            {
                Clipboard.SetText(DingTempLogText.Replace("\r\n", "\n").TrimEnd('\n'));
            }
            else
            {
                Clipboard.SetText("");
            }
        }

        private bool CheckCompletionAndTime()
        {
            if (PanelState.BackColor == Color.Yellow)
            {
                MessageBox.Show("工时不足或百分比不是100%", "警告", MessageBoxButtons.OK);
            }
            if (PanelState.BackColor == Color.Red)
            {
                DialogResult ret = MessageBox.Show("工时不足且百分比不是100% 确定要复制吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void DataGridViewTimeEntry_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataGridViewTimeEntry.IsCurrentCellDirty)
            {
                DataGridViewTimeEntry.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewTimeEntry_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var currGridViewTimeEntry = (TimeEntryModel)((TimeEntryModel)DataGridViewTimeEntry.Rows[e.RowIndex].DataBoundItem).Clone();
            if (currGridViewTimeEntry.IsTemp != TimeEntryModelList[e.RowIndex].IsTemp)
            {
                var issue = issueManager.Get(TimeEntryModelList[e.RowIndex].SubjectId.ToString(), new NameValueCollection());
                if (currGridViewTimeEntry.IsTemp)
                {
                    issue.Subject = "【临时】" + issue.Subject;
                }
                else
                {
                    issue.Subject = issue.Subject.Replace("【临时】", string.Empty);
                }
                issueManager.Update(TimeEntryModelList[e.RowIndex].SubjectId.ToString(), issue);
                _ = ReloadTimeEntry();
            }
        }

        private void DataGridViewTimeEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTimeEntry.Columns[e.ColumnIndex].Name == "Percent" && e.RowIndex >= 0)
            {
                var currGridViewTimeEntry = (TimeEntryModel)((TimeEntryModel)DataGridViewTimeEntry.Rows[e.RowIndex].DataBoundItem).Clone();
                var issue = issueManager.Get(TimeEntryModelList[e.RowIndex].SubjectId.ToString(), new NameValueCollection());
                if (currGridViewTimeEntry.Percent == 100)
                {
                    issue.DoneRatio = 0;
                }
                else
                {
                    issue.DoneRatio = 100;
                }
                issueManager.Update(TimeEntryModelList[e.RowIndex].SubjectId.ToString(), issue);
                _ = ReloadTimeEntry();
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Visible = !Visible;
                if (Visible)
                {
                    TopLevel = true;
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;//关闭窗体时 隐藏窗体 同时取消关闭事件
            e.Cancel = true;
        }

        private void ToolStripItemForNotifyIcon_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "Quit")
            {
                ProgramEnd();
            }
        }

        private void Button_Today_Click(object sender, EventArgs e)
        {
            DateTimePicker.Value = DateTime.Today;
            DateTimePicker.MaxDate = DateTime.Today;
        }

        #region Debug

        private void Timer_Debug_Tick(object sender, EventArgs e)
        {
            Label_CurrentRequestCount.Text = DebugData.CurrentRequestCount.ToString();
        }

        #endregion
    }
}
