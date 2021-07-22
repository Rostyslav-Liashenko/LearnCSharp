using System;

namespace LearnLibrary
{
    class TestSystemDecimal
    {
        static void Main()
        {
            decimal someNumber = new decimal(10);
            Console.WriteLine("Max value = " + Decimal.MaxValue);
            Console.WriteLine("Min value = " + Decimal.MinValue);
            Console.WriteLine("Minus one = " + Decimal.MinusOne);
            Console.WriteLine("One = " + Decimal.One);
            Console.WriteLine("Zero = " + Decimal.Zero);
            Console.WriteLine("decimal(5.75) + decimal(5.25) = " + Decimal.Add(new decimal(5.75), new decimal(5.25)));
            Console.WriteLine("decimal(5.75) - decimal(5.25) = " + Decimal.Subtract(new decimal(5.75), new decimal(5.25)));
            Console.WriteLine("decimal(5.75) * decimal(5.25) = " + Decimal.Multiply(new decimal(5.75), new decimal(5.25)));
            Console.WriteLine("To double");
            double someNumberDouble = Decimal.ToDouble(someNumber);
            Console.WriteLine("Double = " +  someNumberDouble);
        }
    }
}
