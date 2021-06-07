using System;

namespace ConsoleApp6.Shape
{
    public class TwoDShape
    {
        private double priWidth;
        private double priHeight;

        public string name { get; set; }
        

        public TwoDShape()
        {
            Height = Width = 0;
            name = "null";
        }

        public TwoDShape(double x, string n)
        {
            Height = Width = x;
            name = n;
        }
        
        public TwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            name = n;
        }

        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            name = ob.name;
        }
        
        public double Width
        {
            get { return priWidth; } 
            set { priWidth = value < 0 ? -value : value; }
        }

        public double Height
        { 
            get { return priHeight; }
            set { priHeight = value < 0 ? -value : value; }
        }
        
        public void ShowDim()
        {
            Console.WriteLine("Width and height = " + Width + " " + Height);
        }

        public virtual double Area()
        {
            Console.WriteLine("Method Area() not implement in this class");
            return 0.0;
        }
    }
}
