using System;

namespace ConsoleApp1
{
    class DoWhileDemo
    {
        static void Main()
        {
            int num = 198;
            Console.WriteLine("number = " + num);
            Console.WriteLine("Inverse number: ");
            do
            {
                int nextdigit = num % 10;
                Console.Write(nextdigit);
                num /= 10;
            } while (num > 0);
            Console.WriteLine();
        }
    }
}
