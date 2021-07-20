using System;

namespace LearnPointer
{
    class NullableUnityOperatorDemo
    {
        static double GetZeroBal()
        {
            Console.WriteLine("In method GetZeroBal");
            return 0.0;
        }
        
        static void Main()
        {
            double? balance = 123.75;
            double currentBalance;
            currentBalance = balance ?? GetZeroBal();
            Console.WriteLine(currentBalance);
        }
    }
}
