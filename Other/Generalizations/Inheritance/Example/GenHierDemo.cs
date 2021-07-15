using System;

namespace LearnGeneralization
{
    public class GenHierDemo
    {
        static void Main()
        {
            Gen2<string, int> x = new Gen2<string, int>("Value = ", 99);
            Console.Write(x.GetOb());
            Console.WriteLine(x.GetObj2());
        }
    }
}
