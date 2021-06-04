using System;

namespace ConsoleApp6.Shape
{
    public class Triangle : TwoDShape
    {
        private string style;

        public Triangle()
        {
            style = "null";
        }

        public Triangle(double x) : base(x)
        {
            style = "isosceles";
        }
        public Triangle(string s, double w, double h) : base(w, h)
        {
            style = s;
        }
        
        public double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle: " + style);
        }
    }
}
