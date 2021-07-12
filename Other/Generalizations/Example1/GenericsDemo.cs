using System;

namespace LearnGeneralization
{
    class GenericsDemo
    {
        static void Main()
        {
            Gen<int> iOb = new Gen<int>(102);
            iOb.ShowType();
            int v = iOb.GetOb();
            Console.WriteLine("Value = " + v);
            Console.WriteLine();
            Gen<string> strOb = new Gen<string>("It is string");
            strOb.ShowType();
            string str = strOb.GetOb();
            Console.WriteLine("Value: " + str);
        }
    }
}
