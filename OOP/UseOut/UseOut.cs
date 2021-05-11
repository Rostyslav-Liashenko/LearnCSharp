using System;

namespace ConsoleApp3
{
    class UseOut
    {
        static void Main()
        {
            Decompose ob = new Decompose();
            double f;
            int whole = ob.GetParts(10.125, out f);
            Console.WriteLine("Whole parts = " + whole);
            Console.WriteLine("Fact parts = " + f);
        }
    }
}
