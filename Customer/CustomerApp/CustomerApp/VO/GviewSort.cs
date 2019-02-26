using System;

namespace CustomerApp.VO
{
    public static class GviewSort
    {
        public static int Compare(string x, string y)
        {
            return x.CompareTo(y);
        }

        public static int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }

        public static int Compare(DateTime x, DateTime y)
        {
            return x.CompareTo(y);
        }
    }
}
