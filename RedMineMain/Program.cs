using RedMineEditer.CustomException;
using System;
using System.Windows.Forms;

namespace RedMineEditer
{
    static class Program
    {
        static Main form = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            form = new Main();
            Application.Run(form);
            Properties.Settings.Default.Save();
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject.GetType() == new NotLoginException().GetType())
            {
                try
                {
                    form.Logout();
                }
                catch
                {
                    CurrentDomain_UnhandledException(sender, e);
                }
                return;
            }
            Exception ex = e.ExceptionObject as Exception;
            MessageBox.Show(string.Format("捕获到未处理异常：{0}\r\n异常信息：{1}\r\n异常堆栈：{2}\r\nCLR即将退出：{3}", ex.GetType(), ex.Message, ex.StackTrace, e.IsTerminating));
        }

    }
}
