using System;

namespace ConsoleApp1
{
    class PosNeg
    {
        static void Main()
        {
            for (int i = -5; i <= 5; i++)
            {
                Console.Write("Checked " + i + " ");
                if (i < 0)
                    Console.WriteLine("Negative number");
                else
                    Console.WriteLine("Positive number");
            }
        }
    }
}
