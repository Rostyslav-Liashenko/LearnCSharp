using System;
using ConsoleApp6.Shape;

namespace ConsoleApp6
{
    
    class DynShapes
    {
        static void Main()
        {
            TwoDShape[] shapes = new TwoDShape[4];
            shapes[0] = new Triangle("Square triangle",8.0,12.0);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7.0);
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Object -" + shapes[i].name);
                Console.WriteLine("Area - " + shapes[i].Area());
                Console.WriteLine();
            }
        }
    }
}
