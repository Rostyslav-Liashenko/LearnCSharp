using System;

namespace ConsoleApp6.Shape
{
    public class TwoDShape
    {
        private double priWidth;
        private double priHeight;

        public TwoDShape()
        {
            Height = Width = 0;
        }

        public TwoDShape(double x)
        {
            Height = Width = x;
        }
        
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
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
        
    }
}
