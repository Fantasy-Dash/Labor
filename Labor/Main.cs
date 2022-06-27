using Labor.Enums;
using Labor.Manager;
using Labor.Model;
using Labor.Properties;
using Microsoft.Toolkit.Uwp.Notifications;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor
{
    public partial class Main : Form
    {
        LoginInfoEdit LoginInfoEdit = new LoginInfoEdit();
        bool isQuit = false;
        bool isMainForm = true;
        DateTime lastGetIssue = DateTime.Now;
        StringCollection issueExcludeIdList = null;
        List<string> currentIssueIdList = new List<string>();
        List<TimeEntryModel> TimeEntryModelList = null;
        List<Issue> currentIssueList = null;
        StringBuilder LogText = null;

        public Main()
        {
            InitializeComponent();
        }

        #region 处理

        private void Init(bool isFirst)
        {
            if (isFirst)
            {

#if DEBUG
                Label_CurrentRequestCountText.Visible = true;
                Label_CurrentRequestCount.Visible = true;
                Width += 200;
#endif

                #region Setting

                if (!ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).HasFile)
                {
                    Settings.Default.Upgrade();//低版本配置文件复制到高版本配置文件
                }

                #endregion

                Timer.Enabled = true;
                DateTimePicker.Value = DateTime.Today.AddDays(-1);
                DateTimePicker.MaxDate = DateTime.Today;
                DataGridViewIssues.AutoGenerateColumns = false;
                DataGridViewIssues.MultiSelect = false;
                //todo 第一次启动判断弹出是否开机启动
                AutoStart.Text = (Settings.Default.AutoStart ? "√" : "×") + "开机启动";

                ToastManager.Clear();

                issueExcludeIdList = Settings.Default.issueExclude;
                ContextMenuStripForNotifyIcon.ItemClicked += new ToolStripItemClickedEventHandler(ToolStripItemForNotifyIcon_Click);
                if (Settings.Default.IsLogout)
                {
                    Logout();
                }
                else
                {
                    Login();
                }
                ToastNotificationManagerCompat.OnActivated += toastArgs =>
                {
                    ToastArguments args = ToastArguments.Parse(toastArgs.Argument);
                    //todo 无法触发
                    switch (Enum.Parse(typeof(ToastActionType), args.Get("action")))
                    {
                        case ToastActionType.RemindLater:
                            IssueManager.SendToast(args.Get("contentId"), isShow: false);
                            break;
                        case ToastActionType.Click:
                            Invoke((EventHandler)delegate
                            {
                                System.Diagnostics.Process.Start(Settings.Default.RedMineHost + "issues/" + args.Get("contentId"));
                            });
                            break;
                        default:
                            break;
                    }
                };
            }
        }

        private void Login()
        {
            User CurrentUser = Client.Login();
            Settings.Default.IsLogout = false;
            Label_Info.Text = CurrentUser.FirstName + " " + CurrentUser.LastName;
            Timer_GetIssue.Enabled = true;
            Timer_GetIssue_Tick(null, new EventArgs());
            ReloadTimeEntry();
        }

        public void Logout()
        {
            Visible = false;
            Settings.Default.IsLogout = true;
            Timer_GetIssue.Enabled = false;
            var ret = LoginInfoEdit.ShowDialog();
            if (ret != DialogResult.Cancel)
            {
                Login();
                Init(false);
                Visible = true;
            }
            else
            {
                ProgramEnd();
            }
        }

        public void ProgramEnd()
        {
            Visible = false;
            NotifyIcon.Visible = false;//避免关闭程序后右下角图标滞留
            isQuit = true;
            Timer.Enabled = false;
            Settings.Default.issueExclude = issueExcludeIdList;
            Settings.Default.Save();
            ToastManager.Clear();
            Environment.Exit(0);
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
            if (TimeEntryModelList.Count == 0)
            {
                Button_CopyLog.Enabled = false;
                return "暂无";
            }
            else
            {
                LogText = new StringBuilder();
                LogText.AppendLine("今日工作内容（" + DateTimePicker.Value.ToString("yyyy-MM-dd") + "）：");
                for (int taskCount = 1; taskCount <= TimeEntryModelList.Count; taskCount++)
                {
                    LogText.AppendLine(taskCount + "、" + TimeEntryModelList[taskCount - 1].Comments);
                }
                Button_CopyLog.Enabled = true;
                return LogText.ToString().TrimEnd('\n').TrimEnd('\r');
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

        private async void ReloadTimeEntry()
        {
            await Task.Run(() =>
            {
                //todo 重复触发
                var param = new NameValueCollection
                {
                        { Redmine.Net.Api.RedmineKeys.USER_ID, $"=me" },
                        { Redmine.Net.Api.RedmineKeys.SPENT_ON, $"={DateTimePicker.Value:yyyy-MM-dd}" },
                        { Redmine.Net.Api.RedmineKeys.SORT,"spent_on:asc,project" },
                };
                var timeEntryList = TimeEntryManager.GetList(param);
                if (timeEntryList is null)
                {
                    timeEntryList = new List<TimeEntry>();
                }
                TimeEntryModelList = new List<TimeEntryModel>();
                timeEntryList.ForEach(row =>
                {
                    var issue = IssueManager.Get(row.Issue.Id.ToString(), new NameValueCollection());
                    TimeEntryModel tEM = new TimeEntryModel()
                    {
                        Id = row.Id,
                        ProjectName = row.Project.Name.Substring((row.Project.Name.IndexOf('】') + 1)),
                        SubjectId = issue.Id,
                        Subject = issue.Subject,
                        Hours = row.Hours,
                        Percent = issue.DoneRatio,
                        Comments = row.Comments,
                    };
                    TimeEntryModelList.Add(tEM);
                });
                Invoke((EventHandler)delegate
                {
                    DataGridViewTimeEntry.DataSource = new List<TimeEntryModel>(TimeEntryModelList.Select(row => (TimeEntryModel)row.Clone()));
                    LogOutputTextBox.Text = LogOutputRefresh();
                    ChangePanelState();
                    Timer_GetIssue_Tick(null, new EventArgs());
                });
            });
        }

        private async void RefreshIssueList()
        {
            await Task.Run(() =>
            {
                //todo 观察者列表 |

                //todo 取消通知

                //todo 指回bug 要bug
                var bugList = IssueManager.GetBugList();

                foreach (Issue issue in bugList)
                {
                    if (currentIssueIdList.Contains(issue.Id.ToString())) continue;
                    IssueManager.SendToast(issue);
                }
                currentIssueIdList.Clear();
                currentIssueIdList.AddRange(bugList.Select(row => row.Id.ToString()).ToArray());

                var issueList = IssueManager.GetUndoneIssues();
                foreach (Issue issue in issueList)
                {
                    if (issueExcludeIdList.Contains(issue.Id.ToString())) continue;
                    IssueManager.SendToast(issue);
                }
                issueExcludeIdList.Clear();
                issueExcludeIdList.AddRange(issueList.Select(row => row.Id.ToString()).ToArray());

                lastGetIssue = DateTime.Now;
                Settings.Default.issueExclude = issueExcludeIdList;
                Settings.Default.Save();

                if (Visible)
                {
                    Invoke((EventHandler)delegate
                    {
                        currentIssueList = new List<Issue>();
                        currentIssueList.AddRange(issueList);
                        currentIssueList.AddRange(bugList);
                        var list = currentIssueList.Select(row =>
                        {
                            return new IssueModel()
                            {
                                Id = row.Id,
                                Description = row.Description,
                                Subject = row.Subject,
                                DoneRatio = row.DoneRatio,
                                Notes = row.Notes,
                                ProjectName = row.Project.Name,
                            };
                        }).ToList();
                        var index = DataGridViewIssues.CurrentCellAddress;
                        DataGridViewIssues.DataSource = list;
                        if (index.Y > -1 && index.Y > list.Count - 1)
                        {
                            DataGridViewIssues.Rows[list.Count - 1].Cells[index.X].Selected = true;
                        }
                        else if (index.Y > -1 && index.X > -1)
                        {
                            DataGridViewIssues.Rows[index.Y].Cells[index.X].Selected = true;
                        }
                    });
                }
            });
        }

        #endregion

        #region 窗体事件

        private void Main_Load(object sender, EventArgs e) => Init(true);

        private void Main_Activated(object sender, EventArgs e)
        {
            if (!Settings.Default.IsLogout)
            {
                Timer_GetIssue_Tick(null, e);
                isMainForm = true;
                DateTimePicker.MaxDate = DateTime.Today;
                ReloadTimeEntry();
            }
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            if (!Settings.Default.IsLogout)
            {
                isMainForm = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;//关闭窗体时 隐藏窗体 同时取消关闭事件
            if (!isQuit)
            {
                e.Cancel = true;
            }
        }

        private void Button_CopyLog_Click(object sender, EventArgs e)
        {
            //todo 剪贴板win11异常
            if (!CheckCompletionAndTime()) return;
            if (LogOutputTextBox.Text.Length > 0)
            {
                Clipboard.SetText(LogOutputTextBox.Text);
            }
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Button_RefreshIssue_Click(object sender, EventArgs e)
        {
            ToastManager.Clear();
            currentIssueIdList.Clear();
            issueExcludeIdList.Clear();
            RefreshIssueList();
        }

        private void Button_Today_Click(object sender, EventArgs e)
        {
            DateTimePicker.Value = DateTime.Today;
            DateTimePicker.MaxDate = DateTime.Today;
            ReloadTimeEntry();
        }

        private void DateTimePicker_CloseUp(object sender, EventArgs e) => ReloadTimeEntry();

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
        }

        private void DataGridViewTimeEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTimeEntry.Columns[e.ColumnIndex].Name == "Percent" && e.RowIndex >= 0)
            {
                var currGridViewTimeEntry = (TimeEntryModel)((TimeEntryModel)DataGridViewTimeEntry.Rows[e.RowIndex].DataBoundItem).Clone();
                var issue = IssueManager.Get(TimeEntryModelList[e.RowIndex].SubjectId.ToString(), new NameValueCollection());
                if (currGridViewTimeEntry.Percent == 100)
                {
                    issue.DoneRatio = 0;
                }
                else
                {
                    issue.DoneRatio = 100;
                }
                IssueManager.Update(TimeEntryModelList[e.RowIndex].SubjectId.ToString(), issue);
                ReloadTimeEntry();
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Settings.Default.IsLogout && e.Button == MouseButtons.Left)
            {
                Visible = !Visible;
                if (Visible)
                {
                    TopLevel = true;
                }
            }
        }

        private void ToolStripItemForNotifyIcon_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "AutoStart":
                    SystemManager.SetAutoStart(!Settings.Default.AutoStart);
                    AutoStart.Text = (Settings.Default.AutoStart ? "√" : "×") + "开机启动";
                    break;
                case "Quit":
                    ProgramEnd();
                    break;
                default:
                    break;
            }
        }

        private void Timer_GetIssue_Tick(object sender, EventArgs e)
        {
            var isExecute = false;
            if (isMainForm)
            {
                if (Visible)
                {
                    if (lastGetIssue.AddSeconds(3) < DateTime.Now) isExecute = true;
                }
                else
                {
                    if (lastGetIssue.AddSeconds(3) < DateTime.Now) isExecute = true;
                }
            }
            else
            {
                if (Visible)
                {
                    if (lastGetIssue.AddSeconds(30) < DateTime.Now) isExecute = true;
                }
                else
                {
                    if (lastGetIssue.AddMinutes(1) < DateTime.Now) isExecute = true;
                }
            }

            if (isExecute)
            {
                RefreshIssueList();
            }
        }

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
            else if (PictureBox_Loading.Visible)
            {
                Invoke((EventHandler)delegate
                {
                    PictureBox_Loading.Hide();
                });
            }
        }

        private void DataGridViewIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewIssues.Columns[e.ColumnIndex].DataPropertyName == "Subject" && e.RowIndex >= 0)
            {
                System.Diagnostics.Process.Start(Settings.Default.RedMineHost + "issues/" + ((IssueModel)DataGridViewIssues.Rows[e.RowIndex].DataBoundItem).Id);
            }
        }

        private void DataGridViewIssues_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }

        #endregion

    }
}
