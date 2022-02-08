using Redmine.Net.Api.Types;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace RedMineEditer.Manager
{
    public class TimeEntryManager : BaseManager
    {
        public TimeEntry Get(string id, NameValueCollection parameters)
        {
            return GetObject<TimeEntry>(id, parameters);
        }

        public List<TimeEntry> GetList(NameValueCollection parameters)
        {
            return GetObjects<TimeEntry>(parameters);
        }

    }
}
