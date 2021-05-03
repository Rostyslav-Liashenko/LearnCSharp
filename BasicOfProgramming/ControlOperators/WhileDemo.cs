using System;

namespace ConsoleApp1
{
    class WhileDemo
    {
        static void Main()
        {
            int num = 435679;
            int mag = 0;
            Console.WriteLine("Number: " + num);
            while (num > 0)
            {
                mag++;
                num /= 10;
            }
            Console.WriteLine("Order of magnitude: " + mag);
        }
    }
}
