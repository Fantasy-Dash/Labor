using Redmine.Net.Api.Types;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace RedMineEditer.Manager
{
    public class IssueManager : BaseManager
    {
        public Issue Get(string id, NameValueCollection parameters)
        {
            return GetObject<Issue>(id, parameters);
        }

        public List<Issue> Get(NameValueCollection parameters)
        {
            return GetObjects<Issue>(parameters);
        }

        public void Update(string id, Issue obj, string projectId = null)
        {
            UpdateObject(id, obj, projectId);
        }
    }
}
