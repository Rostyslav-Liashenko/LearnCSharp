using System;

namespace LearnLibrary
{
    class SubstringDemo
    {
        static void Main()
        {
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("String str: " + str);
            Console.Write("Substring str.Substring(15): ");
            string substr = str.Substring(15);
            Console.WriteLine(substr);
            Console.Write("Substring str.Substring(0, 15): ");
            substr = str.Substring(0, 15);
            Console.WriteLine(substr);
        }
    }
}
