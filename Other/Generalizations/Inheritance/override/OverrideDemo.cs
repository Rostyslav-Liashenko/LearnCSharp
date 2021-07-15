using System;

namespace LearnGeneralization
{
    public class OverrideDemo
    {
        static void Main()
        {
            Gen<int> iOb = new Gen2<int>(88);
            Console.WriteLine(iOb.GetOb());
            iOb = new Gen2<int>(99);
            Console.WriteLine(iOb.GetOb());
        }
    }
}
