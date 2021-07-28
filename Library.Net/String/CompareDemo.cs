using System;

namespace LearnLibrary
{
    class CompareDemo
    {
        static void Main()
        {
            string str1 = "alpha";
            string str2 = "Alpha";
            string str3 = "Beta";
            string str4 = "alpha";
            string str5 = "alpha, beta";
            int result;
            result = String.Compare(str1, str2, StringComparison.CurrentCulture);
            Console.WriteLine("Culture compare");
            if (result < 0)
                Console.WriteLine(str1 + " < " + str2);
            else if (result > 0)
                Console.WriteLine(str1 + " > " + str2);
            else 
                Console.WriteLine(str1 + " == " + str2);
            result = String.Compare(str1, str2, StringComparison.Ordinal);
            Console.WriteLine("Ordinal compare");
            if (result < 0)
                Console.WriteLine(str1 + " < " + str2);
            else if (result > 0)
                Console.WriteLine(str1 + " > " + str2);
            else
                Console.WriteLine(str1 + " == " + str4);
            
            result = String.CompareOrdinal(str1, str2);
            Console.WriteLine("Compare ordinal");
            if (result < 0)
                Console.WriteLine(str1 + " < " + str2);
            else if (result > 0)
                Console.WriteLine(str1 + " > " + str2);
            else 
                Console.WriteLine(str1 + " == " + str4);
            Console.WriteLine();
            if (str1 == str4)
                Console.WriteLine(str1 + " == " + str4);
            if (str1 != str3)
                Console.WriteLine(str1 + " != " + str3);
            if (str1 != str2)
                Console.WriteLine(str1 + " != " + str2);
            Console.WriteLine();
            if (String.Equals(str1,str2,StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Compare string method Equals() parameter OrdinalIgnoreCase:\n" +
                                  str1 + " equals " + str2);
            Console.WriteLine();
            if (String.Compare(str2, 0, str5, 0, 3) > 0)
                Console.WriteLine("Compare string first 3 symbol string" + str2 + " > 3 first symbol " + str5);
        }
    }
}
