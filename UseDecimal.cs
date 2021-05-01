using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 19.95m;
            decimal discount = 0.15m;
            decimal discountPrice = price - (price * discount);
            Console.WriteLine("Price with discount: {0:C}" + discountPrice);
        }
    }
}
