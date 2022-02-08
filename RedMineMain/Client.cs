using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using RedMineEditer.CustomException;
using RedMineEditer.Properties;

namespace RedMineEditer
{
    public class Client
    {
        private static RedmineManager _redmineManager = null;
        protected RedmineManager RedmineManager { get => _redmineManager; }

        public User Login()
        {
            var host = Settings.Default.RedMineHost;
            var account = Settings.Default.Account;
            var passWord = Settings.Default.Password;
            var apiKey = Settings.Default.ApiKey;
            if (!apiKey.IsNullOrEmpty())
            {
                _redmineManager = new RedmineManager(host, apiKey);
            }
            else if (!account.IsNullOrEmpty())
            {
                _redmineManager = new RedmineManager(host, account, passWord);
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
