namespace RedMineEditer
{
    public static class Extension
    {
        public static T CheckNull<T>(this T obj, string errorMsg)
        {
            if (obj == null)
            {
                throw new System.Exception(errorMsg);
            }
            return obj;
        }

        public static string CheckNull(this string obj, string errorMsg)
        {
            if (string.IsNullOrWhiteSpace(obj))
            {
                throw new System.Exception(errorMsg);
            }
            return obj;
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

    }
}
