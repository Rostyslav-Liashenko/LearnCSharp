using System;

namespace ConsoleApp2
{
    class UseRect
    {
        static void Main()
        {
            Rect r1 = new Rect(5, 10);
            Rect r2 = new Rect(8, 10);
            Console.WriteLine("Area first rectangle = " + r1.Area());
            Console.WriteLine("Area second rectangle = " + r2.Area());
        }
    }   
}
