using Labor.CustomException;
using Labor.Extension;
using Labor.Properties;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System;

namespace Labor
{
    public sealed class Client
    {
        public static RedmineManager RedmineManager = null;

        public static void Init()
        {
            RedmineManager = null;
        }

        public static User Login()
        {
            if (RedmineManager != null) RedmineManager.GetCurrentUser();
            var host = Settings.Default.RedMineHost;
            var account = Settings.Default.Account;
            var passWord = Settings.Default.Password;
            var apiKey = Settings.Default.ApiKey;
            if (!apiKey.IsNullOrEmpty())
            {
                RedmineManager = new RedmineManager(host, apiKey, timeout: new TimeSpan(0, 0, 5));
            }
            else if (!account.IsNullOrEmpty())
            {
                RedmineManager = new RedmineManager(host, account, passWord, timeout: new TimeSpan(0, 0, 5));
            }
            if (RedmineManager is null) throw new NotLoginException();
            try
            {
                return RedmineManager.GetCurrentUser();
            }
            catch { throw new NotLoginException(); }
        }
    }
}
