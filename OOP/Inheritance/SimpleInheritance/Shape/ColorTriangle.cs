using System;

namespace ConsoleApp6.Shape
{
    public class ColorTriangle : Triangle
    {
        private string color;

        public ColorTriangle(string c, string s, double w, double h) : base(s, w, h)
        {
            color = c;
        }
        
        public void ShowColor()
        {
            Console.WriteLine("Color " + color);
        }
    }
}
