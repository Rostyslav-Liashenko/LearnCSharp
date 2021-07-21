using System;

namespace LearnLINQ
{
    class ExtDemo
    {
        static void Main()
        {
            double val = 8.0;
            string str = "Alpha Beta Gamma";
            Console.WriteLine("Reciprocal value {0} = {1}", val, val.Reciprocal());
            Console.WriteLine(str + " after change register: " + str.RevCase());
            Console.WriteLine("Result call method val.AbsDividedBy(-2):" + val.AbsDividedBy(-2));
        }
    }
}
