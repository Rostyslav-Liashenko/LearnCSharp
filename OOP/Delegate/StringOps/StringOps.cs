using System;

namespace LearnDelegate
{
    public class StringOps
    {
        public string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replace space");
            return s.Replace(' ','-');
        }
        
        public string Reverse(string s)
        {
            string temp = "";
            int i, j;
            Console.WriteLine("Reverse string");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            return temp;
        }

        public string RemoveSpaces(string s)
        {
            string temp = "";
            Console.WriteLine("Remove spaces");
            foreach (var t in s)
                if (t != ' ')
                    temp += t;
            return temp;
        }
    }
}
