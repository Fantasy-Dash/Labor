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
        private static readonly Lazy<RedmineManager> lazy = new Lazy<RedmineManager>(() => _redmineManager);
        public static RedmineManager GetClient { get { return lazy.Value; } }

        private static RedmineManager _redmineManager = null;

        public void Init()
        {
            _redmineManager = null;
        }

        public User Login()
        {
            if (_redmineManager != null) _redmineManager.GetCurrentUser();
            var host = Settings.Default.RedMineHost;
            var account = Settings.Default.Account;
            var passWord = Settings.Default.Password;
            var apiKey = Settings.Default.ApiKey;
            if (!apiKey.IsNullOrEmpty())
            {
                _redmineManager = new RedmineManager(host, apiKey, timeout: new TimeSpan(0, 0, 5));
            }
            else if (!account.IsNullOrEmpty())
            {
                _redmineManager = new RedmineManager(host, account, passWord, timeout: new TimeSpan(0, 0, 5));
            }
            if (_redmineManager is null) throw new NotLoginException();
            try
            {
                return _redmineManager.GetCurrentUser();
            }
            catch { throw new NotLoginException(); }
        }
    }
}
