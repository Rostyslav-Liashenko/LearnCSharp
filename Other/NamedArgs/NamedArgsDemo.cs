using System;

namespace ConsoleApp4
{
    class NamedArgsDemo
    {
        static bool IsFactor(int val, int divisor)
        {
            return val % divisor == 0;
        }
        
        static void Main()
        {
            if (IsFactor(10, 2))
                Console.WriteLine("2 is a factor of 10.");
            if (IsFactor(val:10, divisor:2))
                Console.WriteLine("2 is a factor of 10.");
            if (IsFactor(divisor:2, val:10))
                Console.WriteLine("2 is a factor of 10.");
            if (IsFactor(10,divisor:2))
                Console.WriteLine("2 is a factor of 10.");
        }
    }
}
