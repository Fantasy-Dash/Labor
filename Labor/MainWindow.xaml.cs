using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using Labor.Properties;
using Labor.Model;
using Redmine.Net.Api.Types;
using System.Collections.Specialized;
using System.Configuration;
using Labor.Manager;

namespace Labor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        User CurrentUser = null;
        LoginInfoEdit LoginInfoEdit = new LoginInfoEdit();
        StringCollection issueExcludeIdList = null;
        List<TimeEntryModel> TimeEntryModelList = null;
        List<Issue> currentIssueList = null;
        List<string> currentIssueIdList = new List<string>();
        StringBuilder LogText = null;
        public static StringCollection watcherList = Settings.Default.bugWatcherList;

        #region 状态

        bool refreshingTimeEntityList = false;
        bool refreshingIssueList = false;
        bool isQuit = false;
        bool isMainForm = true;
        int issueListVerticalScrollIndex = -1;
        int timeEntityListVerticalScrollIndex = -1;
        DateTime lastGetIssue = DateTime.MinValue;

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        #region 处理

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="isFirst"></param>
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
                DateTimePicker.Value = DateTime.Today;
                DateTimePicker.MaxDate = DateTime.Today;
                DataGridViewIssues.AutoGenerateColumns = false;
                DataGridViewIssues.MultiSelect = false;

                if (Settings.Default.FirstRun)
                {
                    var mssageBoxReturn = MessageBox.Show("是否开机自动启动?", "开机自启", MessageBoxButton.YesNo);
                    SystemManager.SetAutoStart(mssageBoxReturn == MessageBoxResult.Yes);
                    Settings.Default.FirstRun = false;
                    Settings.Default.Save();
                }

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
            }
        }

        /// <summary>
        /// 登入账号
        /// </summary>
        private void Login()
        {
            CurrentUser = Client.Login();
            Settings.Default.IsLogout = false;
            Label_Info.Text = CurrentUser.FirstName + " " + CurrentUser.LastName;
            Timer_GetIssue.Enabled = true;
            Timer_GetIssue_Tick(null, new EventArgs());
            RefreshTimeEntry();
        }

        /// <summary>
        /// 登出账号
        /// </summary>
        public void Logout()
        {
          Visible = false;
            Settings.Default.IsLogout = true;
            Timer_GetIssue.Enabled = false;
            var ret = LoginInfoEdit.ShowDialog();
            if (ret.Value)
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

        /// <summary>
        /// 结束程序
        /// </summary>
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

        /// <summary>
        /// 修改工时指示
        /// </summary>
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
                var timeEntryCommentsList = TimeEntryModelList.Select(row => row.Comments).Distinct().ToList();
                for (int taskCount = 1; taskCount <= timeEntryCommentsList.Count; taskCount++)
                {
                    LogText.AppendLine(taskCount + "、" + timeEntryCommentsList[taskCount - 1]);
                }
                Button_CopyLog.Enabled = true;
                return LogText.ToString().TrimEnd('\n').TrimEnd('\r');
            }
        }

        /// <summary>
        /// 检查工时并提醒
        /// </summary>
        /// <returns></returns>
        private bool CheckCompletionAndTime()
        {
            if (PanelState.BackColor == Color.Yellow)
            {
                MessageBox.Show("工时不足或百分比不是100%", "警告", MessageBoxButton.OK);
            }
            if (PanelState.BackColor == Color.Red)
            {
                var ret = MessageBox.Show("工时不足且百分比不是100% 确定要复制吗？", "警告", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (ret == MessageBoxResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private async void RefreshTimeEntry()
        {
            if (!refreshingTimeEntityList)
            {
                refreshingTimeEntityList = true;
                await Task.Run(() =>
                {
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
                        var index = DataGridViewTimeEntry.CurrentCellAddress;
                        var list = new List<TimeEntryModel>(TimeEntryModelList.Select(row => (TimeEntryModel)row.Clone()));
                        DataGridViewTimeEntry.DataSource = list;

                        if (list.Count > 0)
                        {
                            if (timeEntityListVerticalScrollIndex >= 0)
                            {
                                DataGridViewTimeEntry.FirstDisplayedScrollingRowIndex = timeEntityListVerticalScrollIndex;
                            }
                            DataGridViewTimeEntry.ClearSelection();
                            if (index.Y > -1 && index.Y > list.Count - 1)
                            {
                                DataGridViewTimeEntry.Rows[list.Count - 1].Cells[index.X].Selected = true;
                            }
                            else if (index.Y > -1 && index.X > -1)
                            {
                                DataGridViewTimeEntry.Rows[index.Y].Cells[index.X].Selected = true;
                            }
                        }

                        LogOutputTextBox.Text = LogOutputRefresh();
                        ChangePanelState();
                        Timer_GetIssue_Tick(null, new EventArgs());
                    });
                });
                refreshingTimeEntityList = false;
            }

        }

        private async void RefreshIssueList()
        {
            if (!refreshingIssueList)
            {
                refreshingIssueList = true;
                await Task.Run(() =>
                {
                    //todo 观察者列表 |
                    //todo 指回bug 要bug
                    //todo 开发任务100%
                    var bugList = IssueManager.GetBugList();

                    foreach (Issue issue in bugList)
                    {
                        if (currentIssueIdList.Contains(issue.Id.ToString()))
                        {
                            currentIssueIdList.Remove(issue.Id.ToString());
                            continue;
                        }
                        IssueManager.SendToast(issue);
                    }
                    foreach (var currentIssueId in currentIssueIdList)
                    {
                        IssueManager.RemoveToast(currentIssueId);
                    }
                    currentIssueIdList.Clear();
                    currentIssueIdList.AddRange(bugList.Select(row => row.Id.ToString()).ToArray());

                    var issueList = IssueManager.GetUndoneIssues();
                    foreach (Issue issue in issueList)
                    {
                        if (issueExcludeIdList.Contains(issue.Id.ToString()))
                        {
                            issueExcludeIdList.Remove(issue.Id.ToString());
                            continue;
                        }
                        IssueManager.SendToast(issue);
                    }
                    foreach (var issueExcludeId in issueExcludeIdList)
                    {
                        IssueManager.RemoveToast(issueExcludeId);
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
                                    AuthorId = row.Author.Id,
                                    TrackerType = (TrackerTypeEnum)row.Tracker.Id,
                                    Description = row.Description,
                                    Subject = row.Subject,
                                    DoneRatio = row.DoneRatio,
                                    Notes = row.Notes,
                                    ProjectName = row.Project.Name,
                                };
                            }).ToList();

                            var index = DataGridViewIssues.CurrentCellAddress;
                            DataGridViewIssues.DataSource = list;
                            if (list.Count > 0)
                            {
                                if (issueListVerticalScrollIndex >= 0)
                                {
                                    DataGridViewIssues.FirstDisplayedScrollingRowIndex = issueListVerticalScrollIndex;
                                }
                                DataGridViewIssues.ClearSelection();
                                if (index.Y > -1 && index.Y > list.Count - 1)
                                {
                                    DataGridViewIssues.Rows[list.Count - 1].Cells[index.X].Selected = true;
                                }
                                else if (index.Y > -1 && index.X > -1)
                                {
                                    DataGridViewIssues.Rows[index.Y].Cells[index.X].Selected = true;
                                }
                            }
                        });
                    }
                });
                refreshingIssueList = false;
            }
        }

        #endregion

        private void ButtonPopToast_Click(object sender, RoutedEventArgs e)
        {
            string title = "Andrew sent you a picture";
            string content = "Check this out, The Enchantments!";
            string image = "https://picsum.photos/364/202?image=883";
            int conversationId = 5;

            // Construct the toast content
            new ToastContentBuilder()

                // Arguments when user taps body of toast
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", conversationId)

                // Title and subtitle
                .AddText(title)
                .AddText(content)


                //.AddAppLogoOverride(new Uri(await DownloadImageToDisk("https://unsplash.it/64?image=1005")), ToastGenericAppLogoCrop.Circle)

                .AddInputTextBox("tbReply", "Type a response")

                // Note that for non-UWP apps, there's no need to specify background activation,
                // since our activator decides whether to process in background or launch foreground window
                .AddButton(new ToastButton()
                    .SetContent("Reply")
                    .AddArgument("action", "reply")) // Actions added here supplement (and overwrite) top-level actions

                .AddButton(new ToastButton()
                    .SetContent("Like")
                    .AddArgument("action", "like"))

                .AddButton(new ToastButton()
                    .SetContent("View")
                    .AddArgument("action", "viewImage")
                    .AddArgument("imageUrl", image))

                // And show the toast!
                .Show();
        }

        internal void ShowConversation()
        {
            ContentBody.Content = new TextBlock()
            {
                Text = "You've just opened a conversation!",
                FontWeight = FontWeights.Bold
            };
        }

        internal void ShowImage(string imageUrl)
        {
            ContentBody.Content = new Image()
            {
                Source = new BitmapImage(new Uri(imageUrl))
            };
        }

        private void ButtonClearToasts_Click(object sender, RoutedEventArgs e)
        {
            ToastNotificationManagerCompat.History.Clear();
        }

        #region 窗体事件

        private void Window_Loaded(object sender, RoutedEventArgs e) => Init(true);

        private void Window_Activated(object sender, EventArgs e)
        {
            if (!Settings.Default.IsLogout)
            {
                Timer_GetIssue_Tick(null, e);
                isMainForm = true;
                DateTimePicker.MaxDate = DateTime.Today;
                RefreshTimeEntry();
            }
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            if (!Settings.Default.IsLogout)
            {
                isMainForm = false;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Visible = false;//关闭窗体时 隐藏窗体 同时取消关闭事件
            if (!isQuit)
            {
                e.Cancel = true;
            }
        }

        private void Button_CopyLog_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckCompletionAndTime()) return;
            if (LogOutputTextBox.Text.Length > 0)
            {
                //解决第三方软件读剪贴板时写入异常
                Clipboard.SetDataObject(LogOutputTextBox.Text);
            }
        }

        private void Button_Logout_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }

        private void Button_RefreshIssue_Click(object sender, RoutedEventArgs e)
        {
            ToastManager.Clear();
            currentIssueIdList.Clear();
            issueExcludeIdList.Clear();
            RefreshIssueList();
        }

        private void Button_Today_Click(object sender, RoutedEventArgs e)
        {
            DateTimePicker.Value = DateTime.Today;
            DateTimePicker.MaxDate = DateTime.Today;
            RefreshTimeEntry();
        }

        private void Button_WatcherList_Click(object sender, RoutedEventArgs e)
        {
            new ListEdit().ShowDialog();
            Settings.Default.bugWatcherList = watcherList;
            Settings.Default.Save();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e) => RefreshTimeEntry();

        private void Button_Percent_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    #endregion
}
