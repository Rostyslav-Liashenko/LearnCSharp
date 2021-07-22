using System;

namespace LearnLibrary
{
    class TestSystemDouble
    {
        static void Main()
        {
            Double someNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Epsilon =" + Double.Epsilon);
            Console.WriteLine("Max value = " + Double.MaxValue);
            Console.WriteLine("Min value = " + Double.MinValue);
            Console.WriteLine("Nan = " + Double.NaN);
            Console.WriteLine("Negative Infinity = " + Double.NegativeInfinity);
            Console.WriteLine("Positive Infinity = " + Double.PositiveInfinity);
            if (Double.IsInfinity(someNumber))
                Console.WriteLine("You number is infinity");
            if (Double.IsPositiveInfinity(someNumber))
                Console.WriteLine("You number is positive infinity");
            if (Double.IsNegativeInfinity(someNumber))
                Console.WriteLine("You number is negative infinity");
            if (Double.IsNaN(someNumber))
                Console.WriteLine("You number is not a number");
        }
    }
}
