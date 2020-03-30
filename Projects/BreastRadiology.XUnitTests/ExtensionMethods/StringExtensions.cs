using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public static class StringExtensions
    {
        public static String TrimEnd(this String s, String end)
        {
            if (s.EndsWith(end))
                s = s.Substring(0, s.Length - end.Length);
            return s;
        }

        public static String TrimStart(this String s, String start)
        {
            if (s.StartsWith(start))
                s = s.Substring(start.Length);
            return s;
        }
    }
}