using System;

namespace LearnGeneralization
{
    public class GenHierDemo
    {
        static void Main()
        {
            Gen<string> w = new Gen<string>("Hello", 47);
            Console.WriteLine(w.GetOb() + " ");
            Console.WriteLine(w.GetNum());
        }
    }
}
