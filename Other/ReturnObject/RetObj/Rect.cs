using System;

namespace ConsoleApp3
{
    public class Rect
    {
        private int width;
        private int height;

        public Rect(int w, int h)
        {
            width = w;
            height = h;
        }

        public int Area()
        {
            return width * height;
        }

        public void Show()
        {
            Console.WriteLine(width + " " + height);
        }

        public Rect Enlarge(int fract)
        {
            return new Rect(width * fract, height * fract);
        }
        
    }
}
