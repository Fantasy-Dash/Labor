﻿using Redmine.Net.Api.Types;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Labor.Manager
{
    public class TimeEntryManager : BaseManager
    {
        public static TimeEntry Get(string id, NameValueCollection parameters)
        {
            return GetObject<TimeEntry>(id, parameters);
        }

        public static List<TimeEntry> GetList(NameValueCollection parameters)
        {
            return GetObjects<TimeEntry>(parameters);
        }

    }
}
