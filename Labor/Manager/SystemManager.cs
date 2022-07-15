using Labor.Properties;
using Microsoft.Win32;
using System;
using System.Reflection;
using System.Windows;

namespace Labor.Manager
{
    /// <summary>
    /// 系统管理
    /// </summary>
    public static class SystemManager
    {

        /// <summary>
        /// 设置自启动
        /// </summary>
        public static void SetAutoStart(bool isAutoStart)
        {
            try
            {
                if (isAutoStart == true)
                {
                    RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue("Labor", Assembly.GetExecutingAssembly().Location);
                    R_run.Close();
                    R_local.Close();
                }
                else
                {
                    RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.DeleteValue("Labor", false);
                    R_run.Close();
                    R_local.Close();
                }
                Settings.Default.AutoStart = isAutoStart;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("您需要管理员权限切换开机启动\r\n" + ex.Message);
            }
        }
    }
}
