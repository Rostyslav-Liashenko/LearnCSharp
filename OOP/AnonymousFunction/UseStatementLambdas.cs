using System;

namespace LearnLambda
{
    delegate string StrMod(string s);
    
    class UseStatementLambdas
    {
        static void Main()
        {
            StrMod replaceSpaces = s =>
            {
                Console.WriteLine("Replace space");
                return s.Replace(' ', '-');
            };

            StrMod removeSpaces = s =>
            {
                string temp = "";
                Console.WriteLine("Remove spaces");
                foreach (var t in s)
                    if (t != ' ')
                        temp += t;
                return temp;
            };
            StrMod reverse = s =>
            {
                string temp = "";
                int i, j;
                Console.WriteLine("Reverse string");
                for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                    temp += s[i];
                return temp;
            };
            string str = replaceSpaces("It is simple test");
            Console.WriteLine("Result:" + str);
            Console.WriteLine();
            str = removeSpaces("It is simple test");
            Console.WriteLine("Result:" + str);
            Console.WriteLine();
            str = reverse("It is simple test");
            Console.WriteLine("Result:" + str);
            Console.WriteLine();
        }
    }
