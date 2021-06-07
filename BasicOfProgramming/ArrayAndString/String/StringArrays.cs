using System;

namespace ConsoleApp3
{
    class StringArrays
    {
        static void Main()
        {
            string[] str = {"It's", "very", "easy", "test."};
            Console.WriteLine("Sources string array:");
            foreach (string x in str)
                Console.Write(x + " ");
            Console.WriteLine();
            str[1] = "very very";
            str[3] = "test is completed.";
            Console.WriteLine("Edit string array: ");
            foreach (string x in str)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
