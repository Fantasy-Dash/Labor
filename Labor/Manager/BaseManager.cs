using Labor.Model;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Labor.Manager
{
    public class BaseManager
    {
        internal static T GetObject<T>(string id, NameValueCollection parameters) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            T ret = Client.RedmineManager.GetObject<T>(id, parameters);
            DebugData.CurrentRequestCount--;
            return ret;
        }

        internal static List<T> GetObjects<T>(NameValueCollection parameters) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            List<T> ret = Client.RedmineManager.GetObjects<T>(parameters);
            DebugData.CurrentRequestCount--;
            return ret ?? new List<T>();
        }

        internal static void UpdateObject<T>(string id, T obj, string projectId = null) where T : class, new()
        {
            DebugData.CurrentRequestCount++;
            Client.RedmineManager.UpdateObject(id, obj, projectId);
            DebugData.CurrentRequestCount--;
        }

    }
}