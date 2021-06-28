using System;

namespace LearnDelegate
{
    class MultiCastDemo
    {
        delegate void StrMod(ref string str);

        static void ReplaceSpaces(ref string s)
        {
            Console.WriteLine("Replace spaces");
            s = s.Replace(' ', '-');
        }

        static void RemoveSpaces(ref string s)
        {
            string temp = "";
            Console.WriteLine("Remove Spaces");
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ')
                    temp += s[i];
            s = temp;
        }

        static void Reverse(ref string s)
        {
            string temp = "";
            int i, j;
            Console.WriteLine("Reverse string");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            s = temp;
        }

        static void Main()
        {
            StrMod strOp;
            StrMod replaceSp = ReplaceSpaces;
            StrMod removeSp = RemoveSpaces;
            StrMod reverseStr = Reverse;
            
            string str = "It is simple Test.";
            strOp = replaceSp;
            strOp += reverseStr;
            strOp(ref str);
            Console.WriteLine("Result: " + str);
            Console.WriteLine();
            strOp -= replaceSp;
            strOp += removeSp;
            str = "It is simple test";
            strOp(ref str);
            Console.WriteLine("Result: " + str);
            Console.WriteLine();
        }
    }
}
