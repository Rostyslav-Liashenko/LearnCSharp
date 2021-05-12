using System;

namespace ConsoleApp3
{
    class RetOb
    {
        static void Main()
        {
            Rect r1 = new Rect(4,5);
            Console.WriteLine("Size of rectangle r1:");
            r1.Show();
            Console.WriteLine("Area of rectangle r1:" + r1.Area());
            Console.WriteLine();
            Rect r2 = r1.Enlarge(2);
            Console.WriteLine("Size of rectangle r2:");
            r2.Show();
            Console.WriteLine("Area of rectangle r2:" + r2.Area());
        }
    }
}
