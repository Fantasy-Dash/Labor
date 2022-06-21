using Labor.Enums;
using Redmine.Net.Api.Types;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Labor.Manager
{
    public class IssueManager : BaseManager
    {
        public Issue Get(string id, NameValueCollection parameters)
        {
            return GetObject<Issue>(id, parameters);
        }

        public List<Issue> GetList(NameValueCollection parameters)
        {
            return GetObjects<Issue>(parameters);
        }

        public void Update(string id, Issue obj, string projectId = null)
        {
            UpdateObject(id, obj, projectId);
        }

        public void SendToast(string id, bool isShow = true)
        {
            var issue = GetObject<Issue>(id, new NameValueCollection());
            ToastManager.Send(id, ToastGroupType.Issue, issue.Subject, issue.Description, isShow);
        }

        public void SendToast(List<string> idList, bool isShow = true)
        {
            foreach (var id in idList)
            {
                var issue = GetObject<Issue>(id, new NameValueCollection());
                ToastManager.Send(id, ToastGroupType.Issue, issue.Subject, issue.Description, isShow);
            }
        }

        public void SendToast(Issue issue, bool isShow = true)
        {
            ToastManager.Send(issue.Id.ToString(), ToastGroupType.Issue, issue.Subject, issue.Description, isShow);
        }

        public void SendToast(List<Issue> issueList, bool isShow = true)
        {
            foreach (var issue in issueList)
            {
                ToastManager.Send(issue.Id.ToString(), ToastGroupType.Issue, issue.Subject, issue.Description, isShow);
            }
        }
    }
}
