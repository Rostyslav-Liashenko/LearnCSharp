using System;

namespace ConsoleApp4
{
    class OverloadDemo
    {
        static void Main()
        {
            Overload ob = new Overload();
            ob.OvlDemo();
            Console.WriteLine();
            ob.OvlDemo(2);
            Console.WriteLine();
            int resI = ob.OvlDemo(4, 6);
            Console.WriteLine("Result ob.OvlDemo(4,6) = " + resI);
            Console.WriteLine();
            double resD = ob.OvlDemo(1.1, 2.3);
            Console.WriteLine("Result of ob.OvlDemo(1.1,2.3) = " + resD);
        }
    }
}
