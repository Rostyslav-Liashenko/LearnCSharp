using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            for (double n = 1.0; n <= 10; n++)
            {
                Console.WriteLine("sqrt({0}) = {1}", n, Math.Sqrt(n));
                Console.WriteLine("Whole part = {0}, fraction part = {1}",(int)(Math.Sqrt(n)),Math.Sqrt(n) - (int) (Math.Sqrt(n)));
            }
        }
    }
}  
