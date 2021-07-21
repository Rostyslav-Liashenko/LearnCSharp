using System;

namespace ConsoleApp4
{
    class CLDemo
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Command Line have " + args.Length + " args.");
            Console.WriteLine();
            foreach (string t in args)
                Console.WriteLine(t);
        }
    }
}
