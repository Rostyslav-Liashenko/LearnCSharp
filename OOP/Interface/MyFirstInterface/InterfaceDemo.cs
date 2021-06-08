using System;
using TestDifferentFeatures.TestInterface;

namespace TestDifferentFeatures
{
    class InterfaceDemo
    {

        static void PrintInfoFigure(IFigure someFigure)
        {
            Console.WriteLine("Area = {0:###.##}", someFigure.GetArea());
            Console.WriteLine("Perimeter = {0:###.##}", someFigure.GetPerimeter());
            Console.WriteLine();
        }
        
        static void Main()
        {
            Circle circle = new Circle(5);
            Square square = new Square(12);
            Console.Write("Circle");
            PrintInfoFigure(circle);
            Console.WriteLine("Square");
            PrintInfoFigure(square);
        }
    }
}
