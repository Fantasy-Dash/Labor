using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Labor.Properties;
using Newtonsoft.Json.Linq;

namespace Labor
{
    public partial class FormMain : Form
    {
        List<TaskClass> TaskList=new List<TaskClass>();
        List<TaskClass> TaskListOther=new List<TaskClass>();

        //拖动排序
        int indexSource=0;
        int indexTarget=0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fS= new FileStream("Data.json",FileMode.Open,FileAccess.Read);
                StreamReader sR= new StreamReader(fS,Encoding.UTF8);
                string strData=sR.ReadToEnd();
                JObject data=JObject.Parse(strData);
                List<string> pData=new List<string>();
                for(int i = 0; i < data["Projects"].Count(); i++)
                {
                    pData.Add(data["Projects"][i]["name"].ToString());
                }
                cbP.DataSource = pData;
            }
            catch(Exception ex)
            {
                MessageBox.Show("数据有误程序退出\r\n" + ex.Message);
                System.Environment.Exit(0);
            }
            //todo 每日日志记录
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(tbSummary.Text.Equals("") || tbPst.Text.Equals("") || tbTime.Text.Equals(""))
            {
                MessageBox.Show("填写任务、工时、完成度");
                return;
            }
            TaskClass Newtask = new TaskClass();
            Newtask.Project = cbP.SelectedItem.ToString();
            Newtask.TaskInfo = tbSummary.Text;
            Newtask.Pst = Convert.ToInt32(tbPst.Text);
            Newtask.JobTime = Convert.ToDouble(tbTime.Text);
            if(lbTask.SelectedIndex > -1)
            {
                if(lbTask.SelectedIndex + 1 <= TaskList.Count)
                {
                    TaskList.RemoveAt(lbTask.SelectedIndex);
                    TaskList.Insert(lbTask.SelectedIndex, Newtask);
                }
                else
                {
                    TaskListOther.RemoveAt(lbTask.SelectedIndex - TaskList.Count);
                    TaskListOther.Insert(lbTask.SelectedIndex - TaskList.Count, Newtask);
                }
            }
            else
            {
                if(Newtask.Project != "其他")
                {
                    TaskList.Add(Newtask);
                }
                else
                {
                    TaskListOther.Add(Newtask);
                }
            }
            //todo 拖拽改变顺序
            LBTaskRefresh();
            tbSummary.Text = "";
            tbPst.Text = "";
            tbTime.Text = "";
            lbTask.SelectedIndex = -1;
            tbSummary.Select();
        }

        private void LBTaskRefresh()
        {
            lbTask.Items.Clear();
            int taskCount=1;
            foreach(TaskClass task in TaskList)
            {
                lbTask.Items.Add(taskCount + "、" + task.Project + "  " + task.TaskInfo + "（" + task.Pst + "%，" + task.JobTime + "h）");
                taskCount++;
            }
            foreach(TaskClass task in TaskListOther)
            {
                lbTask.Items.Add(taskCount + "、" + task.Project + "  " + task.TaskInfo + "（" + task.Pst + "%，" + task.JobTime + "h）");
                taskCount++;
            }
            LBTimeRefresh();
            TBARRefresh();
        }

        private void TBARRefresh()
        {
            tbAR.Text = "";
            string strTempProject="";
            int projectTaskCount=0;
            foreach(TaskClass task in TaskList)
            {
                if(task.Project == strTempProject)
                {
                    projectTaskCount += 1;
                    PrintTaskToTBAR(task, projectTaskCount);
                }
                else
                {
                    if(tbAR.Text == "")
                    {
                        tbAR.Text += "【" + task.Project + "】\r\n";
                    }
                    else
                    {
                        tbAR.Text += "\r\n【" + task.Project + "】\r\n";
                    }
                    projectTaskCount = 1;
                    PrintTaskToTBAR(task, projectTaskCount);
                    strTempProject = task.Project;
                }
            }
            foreach(TaskClass task in TaskListOther)
            {
                if(task.Project == strTempProject)
                {
                    projectTaskCount += 1;
                    PrintTaskToTBAR(task, projectTaskCount);
                }
                else
                {
                    if(tbAR.Text == "")
                    {
                        tbAR.Text += "【" + task.Project + "】\r\n";
                    }
                    else
                    {
                        tbAR.Text += "\r\n【" + task.Project + "】\r\n";
                    }
                    projectTaskCount = 1;
                    PrintTaskToTBAR(task, projectTaskCount);
                    strTempProject = task.Project;
                }
            }

        }

        private void PrintTaskToTBAR(TaskClass task, int taskcount)
        {
            tbAR.Text += taskcount + "、" + task.TaskInfo + "（" + task.Pst + "%，" + task.JobTime + "h）\r\n";
        }

        private void LBTimeRefresh()
        {
            var time=0.0;
            foreach(TaskClass task in TaskList)
            {
                time += task.JobTime;
            }
            foreach(TaskClass task in TaskListOther)
            {
                time += task.JobTime;
            }
            lblTime.Text = "总计" + time.ToString("0.0") + "小时";
        }

        private static int CompareByProject(TaskClass x, TaskClass y)//从大到小排序器
        {
            if(x == null)
            {
                if(y == null)
                {
                    return 0;
                }

                return 1;

            }
            if(y == null)
            {
                return -1;
            }
            int retval = y.Project.CompareTo(x.Project);
            return retval;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(TaskList.Count >= lbTask.SelectedIndex + 1)
            {
                foreach(TaskClass task in TaskList)
                {
                    if(TaskList.IndexOf(task) == lbTask.SelectedIndex)
                    {
                        TaskList.RemoveAt(TaskList.IndexOf(task));
                        LBTaskRefresh();
                        lbTask.SelectedIndex = lbTask.Items.Count - 1;
                        return;
                    }
                }
            }
            else
            {
                foreach(TaskClass task in TaskListOther)
                {
                    if(TaskListOther.IndexOf(task) + TaskList.Count == lbTask.SelectedIndex)
                    {
                        TaskListOther.RemoveAt(TaskListOther.IndexOf(task));
                        LBTaskRefresh();
                        lbTask.SelectedIndex = lbTask.Items.Count - 1;
                        return;
                    }
                }
            }
        }

        private void Sort(List<TaskClass> TaskList) => TaskList.Sort(CompareByProject);

        private void BtnSort_Click(object sender, EventArgs e)
        {
            Sort(TaskList);
            Sort(TaskListOther);
            LBTaskRefresh();
        }

        private void LbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=lbTask.SelectedIndex;
            if(index > -1)
            {
                if(index + 1 <= TaskList.Count)
                {
                    cbP.SelectedItem = TaskList[index].Project;
                    tbSummary.Text = TaskList[index].TaskInfo;
                    tbPst.Text = TaskList[index].Pst.ToString();
                    tbTime.Text = TaskList[index].JobTime.ToString("0.0");
                }
                else
                {
                    index -= TaskList.Count;
                    cbP.SelectedItem = TaskListOther[index].Project;
                    tbSummary.Text = TaskListOther[index].TaskInfo;
                    tbPst.Text = TaskListOther[index].Pst.ToString();
                    tbTime.Text = TaskListOther[index].JobTime.ToString("0.0");
                }
            }
        }

        private void BtnSelectClear_Click(object sender, EventArgs e)
        {
            tbSummary.Text = "";
            tbPst.Text = "";
            tbTime.Text = "";
            lbTask.SelectedIndex = -1;
        }

        private void LbTask_MouseDown(object sender, MouseEventArgs e)
        {
            indexSource = ((ListBox)sender).IndexFromPoint(e.X, e.Y);

            if(indexSource != ListBox.NoMatches)
            {
                lbTask.DoDragDrop(lbTask.Items[indexSource].ToString(), DragDropEffects.Copy);
            }
        }

        private void LbTask_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            indexTarget = listbox.IndexFromPoint(listbox.PointToClient(new Point(e.X, e.Y)));
            if(indexTarget != ListBox.NoMatches)
            {
                object obj = listbox.Items[indexSource];
                List<TaskClass> lstMenus = (List<TaskClass>)listbox.DataSource;
                TaskClass modMenu = new TaskClass();
                modMenu = lstMenus[indexSource];

                lstMenus.RemoveAt(indexSource);//从数据源中移除当前拖动项
                lstMenus.Insert(indexTarget, modMenu);//拖动项重新插入到数据源指定位置

                lbTask.DataSource = null;//这句一定要写，我不知道是什么原因，我一直以为winform中数据源回自动更新，可是如果我不释放一下数据源就算排好序，Listbox中也不会显示


                lbTask.DisplayMember = "MenuName";
                lbTask.ValueMember = "ID";
                lbTask.DataSource = lstMenus;//重新设置数据源

                lbTask.SelectedIndex = indexTarget;

            }
        }

        private void LbTask_DragOver(object sender, DragEventArgs e)
        {
            //拖动源和放置的目的地一定是一个ListBox
            if(e.Data.GetDataPresent(typeof(string)) && ((ListBox)sender).Equals(lbTask))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
