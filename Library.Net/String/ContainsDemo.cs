using System;

namespace LearnLibrary
{
    class ContainsDemo
    {
        static void Main()
        {
            string str = "C# has efficient string processing facilities";
            if (str.Contains("facilities"))
                Console.WriteLine("Detecting string facilities");
            if (str.Contains("effi"))
                Console.WriteLine("Detecting string effi");
            if (!str.Contains("effective"))
                Console.WriteLine("substring effective not found");
        }
    }
}
