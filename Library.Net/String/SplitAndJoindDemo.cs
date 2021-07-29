using System;

namespace LearnLibrary
{
    class SplitAndJoinDemo
    {
        static void Main()
        {
            string str = "One on land, another on the sea.";
            char[] seps = {' ', '.', ','};
            string[] parts = str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Result of split string");
            for (int i = 0; i < parts.Length; i++)
                Console.WriteLine(parts[i]);
            string whole = String.Join(" | ", parts);
            Console.WriteLine("Result of join part of string");
            Console.WriteLine(whole);
        }
    }
}
