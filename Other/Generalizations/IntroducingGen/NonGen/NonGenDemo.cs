using System;

namespace LearnGeneralization
{
    class NonGenDemo
    {
        static void Main()
        {
            NonGen iOb = new NonGen(102);
            iOb.ShowType();
            int v = (int) iOb.GetOb();
            Console.WriteLine("Value: " + v);
            Console.WriteLine();
            NonGen strOb = new NonGen("Test");
            strOb.ShowType();
            string str = (string) strOb.GetOb();
            Console.WriteLine("Value: " + str);
            //iOb = strOb; 
            //v = (int) iOb.GetOb(); Exception
        }
    }
}
