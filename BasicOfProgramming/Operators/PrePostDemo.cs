using System;

namespace ConsoleApp1
{
    class PrePostDemo
    {
        static void Main()
        {
            int x = 1, y = 0;
            Console.WriteLine("Sequance number with y += x++");
            for (int i = 0; i < 10; i++)
            {
                y += x++;
                Console.WriteLine("y = " + y);
            }
            Console.WriteLine();
            x = 1;
            y = 0;
            for (int i = 0; i < 10; i++)
            {
                y += ++x;
                Console.WriteLine("y = " + y);
            }
        }
    }
}
