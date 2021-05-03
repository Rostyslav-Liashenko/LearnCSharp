using System;

namespace ConsoleApp1
{
    class BreakDemo
    {
        static void Main()
        {
            for (int i = -10; i <= 10; i++)
            {
                if (i > 0)
                    break;
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("Finish!");
        }
    }
}
