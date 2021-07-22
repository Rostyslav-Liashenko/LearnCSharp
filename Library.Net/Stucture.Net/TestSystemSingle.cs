using System;

namespace LearnLibrary
{
    class TestSystemSingle
    {
        static void Main()
        {
            Single someNumber = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Epsilon =" + Single.Epsilon);
            Console.WriteLine("Max value = " + Single.MaxValue);
            Console.WriteLine("Min value = " + Single.MinValue);
            Console.WriteLine("Nan = " + Single.NaN);
            Console.WriteLine("Negative Infinity = " + Single.NegativeInfinity);
            Console.WriteLine("Positive Infinity = " + Single.PositiveInfinity);
            if (Single.IsInfinity(someNumber))
                Console.WriteLine("You number is infinity");
            if (Single.IsPositiveInfinity(someNumber))
                Console.WriteLine("You number is positive infinity");
            if (Single.IsNegativeInfinity(someNumber))
                Console.WriteLine("You number is negative infinity");
            if (Single.IsNaN(someNumber))
                Console.WriteLine("You number is not a number");
        }
    }
}
