using System;

namespace ConsoleApp1
{
    class NoZeroDiv2
    {
        static void Main()
        {
            for (int i = -5; i < 6; i++)
            {
                if (i != 0 ? (i % 2 == 0) : false)
                    Console.WriteLine("100 / " + i + " = " + 100 / i);
            }
        }
    }
}
