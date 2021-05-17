using System;

namespace ConsoleApp4
{
    class StaticClassDemo
    {
        static void Main()
        {
            Console.WriteLine("The reciprocal of 5 is " + NumericFn.Reciprocal(5.0));
            Console.WriteLine("The fractional part of 4.234 is " + NumericFn.FracPart(4.234));
            if (NumericFn.IsEven(10))
                Console.WriteLine("10 is even number");
            if (NumericFn.IsOdd(5))
                Console.WriteLine("5 is odd number");
        }
    }
}
