using System;

namespace ConsoleApp3
{
    class ValueSwapDemo
    {
        static void Main()
        {
            ValueSwap ob = new ValueSwap();
            int x = 10, y = 20;
            Console.WriteLine("x = " + x + " y = " + y);
            ob.Swap(ref x, ref y);
            Console.WriteLine("x = " + x + " y = " + y);
        }
    }
}
