using System;

namespace ConsoleApp6.Shape
{
    public class Triangle : TwoDShape
    {
        public string Style;

        public double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle: " + Style);
        }
    }
}
