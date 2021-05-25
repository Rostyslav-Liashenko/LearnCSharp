using System;

namespace ConsoleApp4
{
    class UsePwrOfTwo
    {
        static void Main()
        {
            PwrOfTwo pwr = new PwrOfTwo();
            Console.WriteLine("First 8 power number 2:");
            for (int i = 0; i < 8; i++)
                Console.Write(pwr[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Some fail");
            Console.WriteLine(pwr[-1] + " " + pwr[17]);
            Console.WriteLine();
        }
    }
}
