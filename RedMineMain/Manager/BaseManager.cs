using RedMineEditer.Model;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace RedMineEditer.Manager
{
    public class BaseManager : Client
    {
        protected T GetObject<T>(string id, NameValueCollection parameters) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            T ret = RedmineManager.GetObject<T>(id, parameters);
            DebugData.CurrentRequestCount--;
            return ret;
        }

        protected List<T> GetObjects<T>(NameValueCollection parameters) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            List<T> ret = RedmineManager.GetObjects<T>(parameters);
            DebugData.CurrentRequestCount--;
            return ret;
        }

        protected void UpdateObject<T>(string id, T obj, string projectId = null) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            RedmineManager.UpdateObject(id, obj, projectId);
            DebugData.CurrentRequestCount--;
            return;
        }

    }
}