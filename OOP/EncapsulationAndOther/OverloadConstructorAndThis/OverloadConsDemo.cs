using System;

namespace ConsoleApp4
{
    class OverloadConsDemo
    {
        static void Main()
        {
            XYCoord t1 = new XYCoord();
            XYCoord t2 = new XYCoord(8, 9);
            XYCoord t3 = new XYCoord(t2);
            
            Console.WriteLine("t1.x t1.y:" + t1.GetX() + " " + t1.GetY());
            Console.WriteLine("t2.x t2.y:" + t2.GetX() + " " + t2.GetY());
            Console.WriteLine("t3.x t3.y:" + t3.GetX() + " " + t3.GetY());
        }
    }
}
