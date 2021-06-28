using System;

namespace LearnDelegate
{
    class DelegateTest
    {
        delegate string StrMod(string str);

        static string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replace space");
            return s.Replace(' ','-');
        }

        static string RemoveSpaces(string s)
        {
            string temp = "";
            int i;
            Console.WriteLine("Delete spaces");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ')
                    temp += s[i];
            return temp;
        }

        static string Reverse(string s)
        {
            string temp = "";
            int i, j;
            Console.WriteLine("Reverse string");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            return temp;
        }
        
        static void Main()
        {
            StrMod strOp = ReplaceSpaces;
            string str = strOp("It is simple test.");
            Console.WriteLine("Result: " + str);
            Console.WriteLine();
            strOp = RemoveSpaces;
            str = strOp("It is simple test.");
            Console.WriteLine("Result: " + str);
            Console.WriteLine();
            strOp = Reverse;
            str = strOp("It is simple test.");
            Console.WriteLine("Result: " + str);
            Console.WriteLine();
        }
    }
}
