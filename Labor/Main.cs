using Labor.Extension;
using Labor.Manager;
using Labor.Model;
using Labor.Properties;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor
{
    public partial class Main : Form
    {
        string LogText = string.Empty;
        string TempLogText = string.Empty;
        TimeEntryManager timeEntryManager = new TimeEntryManager();
        IssueManager issueManager = new IssueManager();
        List<TimeEntryModel> TimeEntryModelList = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Init(true);
        }

        private void Init(bool isFirst)
        {
            DateTimePicker.MaxDate = DateTime.Today;
            DateTimePicker.Value = DateTime.Today;
            ContextMenuStripForNotifyIcon.ItemClicked += new ToolStripItemClickedEventHandler(ToolStripItemForNotifyIcon_Click);

            if (isFirst)
            {
#if DEBUG
                Label_CurrentRequestCountText.Visible = true;
                Label_CurrentRequestCount.Visible = true;
                Width += 200;
#endif
                #region Setting
                var isLogin = SettingManager.Initialize();

                #endregion

                if (isLogin)
                {
                    Login();
                }
                else
                {
                    Logout();
                }
            }
        }

        private void Login()
        {
            User CurrentUser = new Client().Login();
            Settings.Default.IsLogout = false;
            Label_Info.Text = CurrentUser.FirstName + " " + CurrentUser.LastName;
            ReloadTimeEntry();
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
            Init(false);
            Visible = true;
        }

        public void ProgramEnd()
        {
            NotifyIcon.Visible = false;//避免关闭程序后右下角图标滞留
            Environment.Exit(0);
        }

        public void SwitchAutoStart()
        {
            //todo 切换开机启动
        }

        private void DateTimePicker_CloseUp(object sender, EventArgs e) => ReloadTimeEntry();

        private async void ReloadTimeEntry()
        {
            await Task.Run(() =>
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
                Invoke((EventHandler)delegate
                {
                    DataGridViewTimeEntry.DataSource = new List<TimeEntryModel>(TimeEntryModelList.Select(row => (TimeEntryModel)row.Clone()));
                    DingLogOutputTextBox.Text = LogOutputRefresh();
                    ChangePanelState();
                });
            });
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            DateTimePicker.MaxDate = DateTime.Today;
            ReloadTimeEntry();
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

        /// <summary>
        /// 返回日志拼装
        /// </summary>
        /// <returns></returns>
        private string LogOutputRefresh()
        {
            string strTempProject = string.Empty;
            int projectTaskCount = 0;
            List<TimeEntryModel> tempTimeEntryModelList = new List<TimeEntryModel>();
            LogText = string.Empty;
            foreach (TimeEntryModel task in TimeEntryModelList)
            {
                if (!task.IsTemp)
                {
                    DrawText(ref LogText, task, ref strTempProject, ref projectTaskCount);
                }
                else
                {
                    tempTimeEntryModelList.Add(task);
                }
            }
            TempLogText = string.Empty;
            strTempProject = string.Empty;
            projectTaskCount = 0;
            foreach (TimeEntryModel task in tempTimeEntryModelList)
            {
                DrawText(ref TempLogText, task, ref strTempProject, ref projectTaskCount);
            }
            if (LogText.IsNullOrEmpty())
            {
                Button_CopyLog.Enabled = false;
                return "暂无";
            }
            else
            {
                Button_CopyLog.Enabled = true;
                return LogText.TrimEnd('\n').TrimEnd('\r');
            }
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
            if (!LogText.IsNullOrEmpty())
            {
                Clipboard.SetText(LogText.Replace("\r\n", "\n").TrimEnd('\n'));
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
                ReloadTimeEntry();
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
                ReloadTimeEntry();
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
            switch (e.ClickedItem.Name)
            {
                case "AutoStart": SwitchAutoStart(); break;
                case "Quit": ProgramEnd(); break;
                default:
                    break;
            }
        }

        private void Button_Today_Click(object sender, EventArgs e)
        {
            DateTimePicker.Value = DateTime.Today;
            DateTimePicker.MaxDate = DateTime.Today;
            ReloadTimeEntry();
        }

        #region Debug

        private void Timer_Tick(object sender, EventArgs e)
        {
#if DEBUG
            Invoke((EventHandler)delegate
            {
                Label_CurrentRequestCount.Text = DebugData.CurrentRequestCount.ToString();
            });
#endif
            if (DebugData.CurrentRequestCount > 0)
            {
                if (!PictureBox_Loading.Visible)
                {
                    Invoke((EventHandler)delegate
                    {
                        PictureBox_Loading.Show();
                    });
                }
            }
            else
            {
                Invoke((EventHandler)delegate
                {
                    PictureBox_Loading.Hide();
                });
            }
        }

        #endregion

    }
}
