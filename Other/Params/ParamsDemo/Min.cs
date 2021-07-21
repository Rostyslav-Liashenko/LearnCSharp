using System;

namespace ConsoleApp3
{
    class ParamsDemo
    {
        static void Main()
        {
            Min ob = new Min();
            int a = 10, b = 20;
            int min = ob.MinVal(a, b);
            Console.WriteLine("min = " + min);
            min = ob.MinVal(a, b, -1);
            Console.WriteLine("min = " + min);
            min = ob.MinVal(18, 23, 3, 14, 25);
            Console.WriteLine("min = " + min);
            int[] args = {45, 67, 34, 9, 112, 18};
            min = ob.MinVal(args);
            Console.WriteLine("min = " + min);
        }
        
    }
}
