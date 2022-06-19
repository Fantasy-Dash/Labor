using Labor.Properties;
using System;
using System.Windows.Forms;

namespace Labor.Manager
{
    public static class SettingManager
    {
        public static bool Initialize()
        {
            var version = new Version(Settings.Default.ConfigVersion);
            var applicationVersion = new Version(Application.ProductVersion);
            if (version.CompareTo(applicationVersion) != 0)
            {
                Settings.Default.CurrentVersionFirstRun = true;
                Settings.Default.ConfigVersion = Application.ProductVersion;
            }
            for (int i = 0; i < applicationVersion.Major; i++)//版本判断
            {
                switch (i)
                {
                    case 0: Settings.Default.FirstRun = true; break;
                    case 1:
                    default:
                        break;
                }
            }

            if (Settings.Default.IsLogout) { return false; }//上次是否退出
            else { return true; }
        }
    }
}
