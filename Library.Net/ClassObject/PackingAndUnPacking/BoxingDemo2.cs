using System;

namespace ConsoleApp6
{
    class BoxingDemo
    {
        static int Sqr(object o)
        {
            return (int) o * (int) o;
        }
        static void Main()
        {
            int x = 10;
            Console.WriteLine("x = " + x);
            x = Sqr(x);
            Console.WriteLine("Value x^2 = " + x);
        }
    }
}
