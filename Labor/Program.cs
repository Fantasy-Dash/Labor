using Labor.CustomException;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Labor
{
    static class Program
    {
        static Main form = null;
        /// <summary>
        /// 应用程序主入口
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += ThreadException;
            form = new Main();
            Application.Run(form);
        }

        /// <summary>
        /// 捕获全局异常进行处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception.GetType() == new NotLoginException().GetType())
            {
                try
                {
                    Client client = new Client();
                    client.Init();
                    form.Logout();
                }
                catch (NotLoginException)
                {
                    form.Logout();
                }
                catch (Exception)
                {
                    ThreadException(sender, e);
                }
                return;
            }
            Exception ex = e.Exception;
            MessageBox.Show(string.Format("捕获到未处理异常：{0}\r\n异常信息：{1}\r\n异常堆栈：{2}", ex.GetType(), ex.Message, ex.StackTrace));
        }

    }
}
