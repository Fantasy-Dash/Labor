using Labor.Model;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Labor.Manager
{
    public class BaseManager
    {
        protected T GetObject<T>(string id, NameValueCollection parameters) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            T ret = Client.GetClient.GetObject<T>(id, parameters);
            DebugData.CurrentRequestCount--;
            return ret;
        }

        protected List<T> GetObjects<T>(NameValueCollection parameters) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            List<T> ret = Client.GetClient.GetObjects<T>(parameters);
            DebugData.CurrentRequestCount--;
            return ret;
        }

        protected void UpdateObject<T>(string id, T obj, string projectId = null) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            Client.GetClient.UpdateObject(id, obj, projectId);
            DebugData.CurrentRequestCount--;
            return;
        }

    }
}