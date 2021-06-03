using System;
using ConsoleApp6.Shape;

namespace ConsoleApp6
{
    class Shapes
    {
        static void Main()
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "isosceles";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "Square";
            
            Console.WriteLine("Info of object t1:");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area =" + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Info of object t2:");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area = " + t2.Area());
        }
    }
}
