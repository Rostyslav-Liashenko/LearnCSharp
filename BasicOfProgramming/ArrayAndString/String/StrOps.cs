using System;
using System.Globalization;

namespace ConsoleApp3
{
    class StrOps
    {
        static void Main()
        {
            string str1 = "Programming in .Net better in C#";
            string str2 = "Programming in .Net better in C#";
            string str3 = "String in C# very effective";
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("Length string str1: " + str1.Length);
            string strLow = str1.ToLower(CultureInfo.CurrentCulture);
            string strUp = str1.ToUpper(CultureInfo.CurrentCulture);
            Console.WriteLine("Str1 in small symbols: " + strLow);
            Console.WriteLine("Str1 in big symbols: " + strUp);
            Console.WriteLine();
            foreach (char t in str1)
                Console.Write(t);
            Console.WriteLine("\n");
            Console.WriteLine(str1 == str2 ? "str1 == str2" : "str1 != str2");
            Console.WriteLine(str1 == str3 ? "str1 == str3" : "str1 != str3");
            int result = string.Compare(str3, str1, StringComparison.CurrentCulture);
            if (result == 0)
                Console.WriteLine("str3 == str1");
            else if (result < 0)
                Console.WriteLine("str1 < str3");
            else 
                Console.WriteLine("str1 > str3");
            Console.WriteLine();
            str2 = "One two three One";
            int idx = str2.IndexOf("One", StringComparison.Ordinal);
            Console.WriteLine("Index of the first occurrence of substring <One>" + idx);
            idx = str2.LastIndexOf("One", StringComparison.Ordinal);
            Console.WriteLine("Index of the last occurrence of substring <Two>" + idx);
        }
    }
}
