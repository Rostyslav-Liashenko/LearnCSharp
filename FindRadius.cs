using System;

namespace ConsoleApp1
{
    class FindRadius
    {
        static void Main(string[] args)
        {
            double area = 10.0;
            double r = Math.Sqrt(area / Math.PI);
            Console.WriteLine("Radius circle = " + r);
        }
    }
}
