using System;

namespace LearnGeneralization
{
    
    class GenIntfDemo
    {
        static int IntPlusTwo(int v)
        {
            return v + 2;
        }

        static double DoublePlusTwo(double v)
        {
            return v + 2.0;
        }

        static ThreeD ThreeDPlustTwo(ThreeD v)
        {
            if (v == null)
                return new ThreeD(0, 0, 0);
            else
                return new ThreeD(v.X + 2, v.Y + 2,v.Z + 2);
        }

        static void Main()
        {
            ByTwos<int> intBT = new ByTwos<int>(IntPlusTwo);
            for (int i = 0; i < 5; i++)
                Console.Write(intBT.GetNext() + " ");
            Console.WriteLine();
            ByTwos<double> dblBT = new ByTwos<double>(DoublePlusTwo);
            dblBT.SetStart(11.4);
            for (int i = 0; i < 5; i++)
                Console.Write(dblBT.GetNext() + " ");
            Console.WriteLine();
            ByTwos<ThreeD> ThrDBT = new ByTwos<ThreeD>(ThreeDPlustTwo);
            ThreeD coord;
            for (int i = 0; i < 5; i++)
            {
                coord = ThrDBT.GetNext();
                Console.Write(coord.X + ", " + coord.Y + ", " + coord.Z + "   ");
            }
            Console.WriteLine();
        }
        
    }
}
