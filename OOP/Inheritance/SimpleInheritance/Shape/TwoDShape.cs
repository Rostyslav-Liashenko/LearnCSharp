using System;

namespace ConsoleApp6.Shape
{
    public class TwoDShape
    {
        private double priWidth;
        private double priHeight;

        public double Width
        {
            get
            {
                return priWidth;
            }
            set
            {
                priWidth = value < 0 ? -value : value;
            }
        }

        public double Height
        {
            get
            {
                return priHeight;
            }
            set
            {
                priHeight = value < 0 ? -value : value;
            }
        }
        
        public void ShowDim()
        {
            Console.WriteLine("Width and height = " + Width + " " + Height);
        }
        
    }
}
