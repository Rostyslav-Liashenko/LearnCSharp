using System;

namespace LearnDelegate
{
    class DelegateTestWithObject
    {
        delegate string StrMod(string str);
        
        static void Main()
        {
            StringOps so = new StringOps();
            StrMod strOp = so.ReplaceSpaces;
            string str = strOp("It is simple test.");
            Console.WriteLine("Result: " + str);
            Console.WriteLine();
            strOp = so.RemoveSpaces;
            str = strOp("It is simple test.");
            Console.WriteLine("Result: " + str);
            Console.WriteLine();
            strOp = so.Reverse;
            str = strOp("It is simple test.");
            Console.WriteLine("Result: " + str);
            Console.WriteLine();
        }
    }
}
