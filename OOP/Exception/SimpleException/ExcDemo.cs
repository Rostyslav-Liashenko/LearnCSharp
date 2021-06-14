using System;

namespace LearnException
{
    class ExcDemo
    { 
        static void Main()
        {
            int[] number = {4, 8, 16, 32, 64, 128};
            int[] denom = {2, 0, 4, 4, 0, 8};
            for (int i = 0; i < number.Length; i++)
            {
                try
                {
                    Console.WriteLine(number[i] + "/" + denom[i] + " = " + number[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by 0");
                }
            }
        }
    }
}
