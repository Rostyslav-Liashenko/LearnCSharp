using System;
using System.Globalization;

namespace LearnLINQ
{
    public static class MyExtMeths
    {
        public static double Reciprocal(this double v)
        {
            return 1.0 / v;
        }

        public static string RevCase(this string str)
        {
            string temp = "";
            foreach (char ch in str)
            {
                if (Char.IsLower(ch))
                    temp += Char.ToUpper(ch, CultureInfo.CurrentCulture);
                else
                    temp += Char.ToLower(ch, CultureInfo.CurrentCulture);
            }
            return temp;
        }

        public static double AbsDividedBy(this double n, double d)
        {
            return Math.Abs(n / d);
        }
    }
}
