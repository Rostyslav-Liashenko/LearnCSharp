using System;

namespace ConsoleApp4
{
    class SDemo
    {
    
        static void Main()
        {
            Console.WriteLine("StaticDemo.Val = " + StaticDemo.Val);
            StaticDemo.Val = 8;
            Console.WriteLine("StaticDemo.Val = " + StaticDemo.Val);
            Console.WriteLine("StaticDemo.ValDev2() = " + StaticDemo.ValDiv2());
        }
    }
}
