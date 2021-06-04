using System;
using ConsoleApp6.Shape;

namespace ConsoleApp6
{
    class Shapes
    {
        static void Main()
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle("Square", 8.0, 12.0);
            Triangle t3 = new Triangle(4.0);
            
            t1 = t2;
            
            Console.WriteLine("Info of object t1:");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area equals " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Info of object t2:");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area equals " + t2.Area());
            Console.WriteLine();
            Console.WriteLine("Info of object t3:");
            t3.ShowStyle();
            t3.ShowDim();
            Console.WriteLine("Area equals " + t3.Area());
        }
    }
}
