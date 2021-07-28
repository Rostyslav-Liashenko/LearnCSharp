using System;

namespace LearnLibrary
{
    class ConcatDemo2
    {
        static void Main()
        {
            string result = String.Concat("Value  = ", 19);
            Console.WriteLine("Result: " + result);
            result = String.Concat("Hello ", 88, " ", 20.0, " ", false, " ", 23.45M);
            Console.WriteLine("Result: " + result);
        }
    }
}
