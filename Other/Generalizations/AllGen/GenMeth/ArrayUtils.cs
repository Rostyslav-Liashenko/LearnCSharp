using System;

namespace LearnGeneralization
{
    class StructTest
    {
       static void Main()
       {
           XY<int> coord1 = new XY<int>(5,2);
           XY<double> coord2 = new XY<double>(99.5, 23.4);
           Console.WriteLine("Coord1: X = " + coord1.X + " Y = " + coord1.Y);
           Console.WriteLine("Coord2: X = " + coord2.X + " Y = " + coord2.Y);
       }
    }
}
