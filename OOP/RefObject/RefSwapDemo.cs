using System;

namespace ConsoleApp3
{
    class RefSwapDemo
    {
        static void Main()
        {
            RefSwap x = new RefSwap(1, 2);
            RefSwap y = new RefSwap(3, 4);
            Console.WriteLine("object x before call: ");
            x.Show();
            Console.WriteLine("object y before call:");
            y.Show();
            x.Swap(ref x, ref y);
            Console.WriteLine();
            Console.WriteLine("object x after call: ");
            x.Show();
            Console.WriteLine("object y after call:");
            y.Show();
        }
        
    }
}
