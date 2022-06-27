using Labor.Enums;
using Labor.Properties;
using Redmine.Net.Api.Types;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Labor.Manager
{
    public class IssueManager : BaseManager
    {
        public static Issue Get(string id, NameValueCollection parameters)
        {
            return GetObject<Issue>(id, parameters);
        }

        public static List<Issue> GetList(NameValueCollection parameters)
        {
            return GetObjects<Issue>(parameters);
        }

        public static void Update(string id, Issue obj, string projectId = null)
        {
            UpdateObject(id, obj, projectId);
        }

        /// <summary>
        /// 获取bug列表
        /// </summary>
        /// <returns></returns>
        public static List<Issue> GetBugList()
        {
            var bugParam = new NameValueCollection
                {
                        { Redmine.Net.Api.RedmineKeys.ASSIGNED_TO_ID, "=me|"+string.Join("|",Settings.Default.bugWatcherList) },
                        { Redmine.Net.Api.RedmineKeys.TRACKER_ID, $"=8" },
                };
            return GetList(bugParam);
        }

        /// <summary>
        /// 获取未完成任务列表
        /// </summary>
        /// <returns></returns>
        public static List<Issue> GetUndoneIssues()
        {
            var issueParam = new NameValueCollection
                {
                        { Redmine.Net.Api.RedmineKeys.ASSIGNED_TO_ID, $"=me" },
                        { Redmine.Net.Api.RedmineKeys.TRACKER_ID, $"=2" },
                        { Redmine.Net.Api.RedmineKeys.STATUS_ID, $"=2" },
                        { Redmine.Net.Api.RedmineKeys.DONE_RATIO, $"<=99" },
                };
            return GetList(issueParam);
        }

        public static void SendToast(string id, bool isShow = true)
        {
            var issue = GetObject<Issue>(id, new NameValueCollection());
            ToastManager.Send(id, ToastGroupType.Issue, issue.Subject, issue.Description, isShow);
        }

        public static void SendToast(List<string> idList, bool isShow = true)
        {
            foreach (var id in idList)
            {
                var issue = GetObject<Issue>(id, new NameValueCollection());
                ToastManager.Send(id, ToastGroupType.Issue, issue.Subject, issue.Description, isShow);
            }
        }

        public static void SendToast(Issue issue, bool isShow = true)
        {
            ToastManager.Send(issue.Id.ToString(), ToastGroupType.Issue, issue.Subject, issue.Description, isShow);
        }

        public static void SendToast(List<Issue> issueList, bool isShow = true)
        {
            foreach (var issue in issueList)
            {
                ToastManager.Send(issue.Id.ToString(), ToastGroupType.Issue, issue.Subject, issue.Description, isShow);
            }
        }

        public static void RemoveToast(string issueId)
        {
            ToastManager.Remove(issueId, ToastGroupType.Issue);
        }

        public static void RemoveToast(List<string> issueIdList)
        {
            foreach (var issueId in issueIdList)
            {
                ToastManager.Remove(issueId, ToastGroupType.Issue);
            }
        }
    }
}
