using System;
using System.Globalization;
namespace LearnPartical
{
    class DynDemo
    {
        static void Main(string[] args)
        {
            dynamic str;
            dynamic val;

            str = "It is string";
            val = 10;
            Console.WriteLine("Variable string have: " + str);
            Console.WriteLine("Variable val have: " + val);
            str = str.ToUpper(CultureInfo.CurrentCulture);
            Console.WriteLine("Variable string now have: " + str);
            val = val + 2;
            Console.WriteLine("Variable val now have: " + val);
            string str2 = str.ToLower(CultureInfo.CurrentCulture);
            Console.WriteLine("Variable str2 have:" + str2);
            int x = val * 2;
            Console.WriteLine("Variable x have:" + x);
        }
    }
}
