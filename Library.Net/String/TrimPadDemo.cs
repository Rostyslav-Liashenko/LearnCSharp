using System;

namespace LearnLibrary
{
    class TrimPadDemo
    {
        static void Main()
        {
            string str = "test";
            Console.WriteLine("Sources string: " + str);
            str = str.PadLeft(10);
            Console.WriteLine("|" + str + "|");
            str = str.PadRight(20);
            Console.WriteLine("|" + str + "|");
            str = str.Trim();
            Console.WriteLine("|" + str + "|");
            str = str.PadLeft(10, '#');
            Console.WriteLine("|" + str + "|");
            str = str.PadRight(20, '#');
            Console.WriteLine("|" + str + "|");
            str = str.Trim('#');
            Console.WriteLine("|" + str + "|");
        }
    }
}
