using System;

namespace ConsoleApp4
{
    public class XYCoord
    {
        private int x;
        private int y;

        public XYCoord(int i, int j)
        {
            Console.WriteLine("In constructor int, int");
            x = i;
            y = j;
        }
        public XYCoord() : this(0, 0)
        {
            Console.WriteLine("In constructor ()");
        }

        public XYCoord(XYCoord obj) : this(obj.x, obj.y)
        {
            Console.WriteLine("In constructor(obj)");
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
        
    }
}
