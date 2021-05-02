using System;

namespace ConsoleApp1
{
    class ModDemo
    {
        static void Main()
        {
            int iresult = 10 / 3;
            double irem = 10 % 3;
            double dresult = 10.0 / 3.0;
            double drem = 10.0 % 3.0;
            Console.WriteLine("Result from mod 10 / 3:" + iresult + " " + irem);
            Console.WriteLine("Result from mod 10 / 3:" + dresult + " " + drem);
        }
    }
}
