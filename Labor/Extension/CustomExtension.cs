using System;

namespace Labor.Extension
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class CustomExtension
    {
        public static T CheckNull<T>(this T obj, string errorMsg)
        {
            if (obj == null)
            {
                throw new Exception(errorMsg);
            }
            return obj;
        }

        public static string CheckNull(this string obj, string errorMsg)
        {
            if (string.IsNullOrWhiteSpace(obj))
            {
                throw new Exception(errorMsg);
            }
            return obj;
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

    }
}
