using System;

namespace ConsoleApp1
{
    class ContDemo
    {
        static void Main()
        {
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) != 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
