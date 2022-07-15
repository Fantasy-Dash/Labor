namespace Labor.Model
{
    public static class DebugData
    {
        private static int currentRequestCount;

        public static int CurrentRequestCount
        {
            get
            {
                return currentRequestCount;
            }
            set
            {
                currentRequestCount = value > 0 ? value : 0;
            }
        }
    }
}
