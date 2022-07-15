using Labor.Enums;
using Labor.Manager;
using Labor.Model;
using Labor1.Properties;
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



        #region 窗体事件

        private void Main_Load(object sender, EventArgs e) => Init(true);

        private void Main_Activated(object sender, EventArgs e)
        {
            if (!Settings.Default.IsLogout)
            {
                Timer_GetIssue_Tick(null, e);
                isMainForm = true;
                DateTimePicker.MaxDate = DateTime.Today;
                RefreshTimeEntry();
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
            if (!CheckCompletionAndTime()) return;
            if (LogOutputTextBox.Text.Length > 0)
            {
                //解决第三方软件读剪贴板时写入异常
                Clipboard.SetDataObject(LogOutputTextBox.Text);
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
            RefreshTimeEntry();
        }

        private void Button_WatcherList_Click(object sender, EventArgs e)
        {
            new ListEdit().ShowDialog();
            Settings.Default.bugWatcherList = watcherList;
            Settings.Default.Save();
        }

        private void DateTimePicker_CloseUp(object sender, EventArgs e) => RefreshTimeEntry();

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
                RefreshTimeEntry();
            }
        }

        private void DataGridViewTimeEntry_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                timeEntityListVerticalScrollIndex = e.NewValue;
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
            if (e.RowIndex >= 0)
            {
                var entity = DataGridViewIssues.Columns[e.ColumnIndex];
                if (entity is DataGridViewButtonColumn)
                {

                }
                else if (entity is DataGridViewLinkColumn)
                {
                    System.Diagnostics.Process.Start(Settings.Default.RedMineHost + "issues/" + ((IssueModel)DataGridViewIssues.Rows[e.RowIndex].DataBoundItem).Id);
                }
            }
        }

        private void DataGridViewIssues_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }

        private void DataGridViewIssues_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                issueListVerticalScrollIndex = e.NewValue;
            }
        }

        #endregion


    }
}
