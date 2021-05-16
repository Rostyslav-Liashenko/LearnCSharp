using System;

namespace ConsoleApp4
{
    class Recursion
    {
    
        static void Main()
        {
            string s = "It is test";
            RevStr rsOb = new RevStr();
            Console.WriteLine("Source string :" + s);
            Console.WriteLine("Reverse string :");
            rsOb.DisplayRev(s);
            Console.WriteLine();
        }
    }
}
