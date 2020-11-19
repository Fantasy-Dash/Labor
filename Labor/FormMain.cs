using System;
using System.Collections.Generic;
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
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string tb=tbText.Text;

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
                MessageBox.Show("数据有误程序退出\r\n"+ex.Message);
                System.Environment.Exit(0);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(tbText.Text.Split('·').Length < 3)
            {
                MessageBox.Show("填写工时和完成度");
                return;
            }
            TaskClass Newtask = new TaskClass();
            Newtask.Project = cbP.SelectedItem.ToString();
            Newtask.TaskInfo = tbText.Text.Split('·')[0];
            Newtask.Pst = Convert.ToInt32(tbText.Text.Split('·')[1]);
            Newtask.JobTime = Convert.ToDouble(tbText.Text.Split('·')[2]);
            if(Newtask.Project != "其他")
            {
                TaskList.Add(Newtask);
            }
            else
            {
                TaskListOther.Add(Newtask);
            }
            TaskList.Sort(CompareByProject);
            LBTaskRefresh();
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
           if(TaskList.Count>=lbTask.SelectedIndex+1)
            {
                foreach(TaskClass task in TaskList)
                {
                    if(TaskList.IndexOf(task) == lbTask.SelectedIndex)
                    {
                        TaskList.RemoveAt(TaskList.IndexOf(task));
                        LBTaskRefresh();
                        return;
                    }
                }
            }
            else
            {
                foreach(TaskClass task in TaskListOther)
                {
                    if(TaskListOther.IndexOf(task)+TaskList.Count == lbTask.SelectedIndex)
                    {
                        TaskListOther.RemoveAt(TaskListOther.IndexOf(task));
                        LBTaskRefresh();
                        return;
                    }
                }
            }
        }
    }
}
