using System;

namespace ConsoleApp1
{
    class ForWithoutBody
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 1; i <= 5; sum += i++) ;
            Console.WriteLine("sum = " + sum);
        }
    }
}
