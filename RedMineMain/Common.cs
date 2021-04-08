using System;
using Redmine.Net.Api.Extensions;

namespace RedMine
{
    public static class Common
    {
        public static T CheckNull<T>(this T obj, string errorMsg)
        {
            if(obj == null)
            {
                throw new Exception(errorMsg);
            }
            return obj;
        }

        public static string CheckNull(this string obj, string errorMsg)
        {
            if(obj.IsNullOrWhiteSpace())
            {
                throw new Exception(errorMsg);
            }
            return obj;
        }


    }
}
