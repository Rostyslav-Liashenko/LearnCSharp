using System;

namespace LearnAnonymoss
{
    delegate string StringOperation(string str);
    
    class PracticeAnonymousMethod
    {
        static void Main()
        {
            StringOperation myOpr = delegate(string str)
            {
                Console.WriteLine("Replace spaces");
                return str.Replace(' ', '-');
            };
            string s = "It is simple test";
            s = myOpr(s);
            Console.WriteLine(s);
            myOpr = delegate(string str)
            {
                string temp = "";
                for (int i = 0; i < str.Length; i++)
                    if (str[i] != ' ')
                        temp += str[i];
                return temp;
            };
            s = myOpr("It is simple test");
            Console.WriteLine(s);
        }
    }
}
