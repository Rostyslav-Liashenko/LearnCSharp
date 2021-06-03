using System;

namespace ConsoleApp4
{
    class ConsDemo
    {
        static void Main()
        {
            Cons ob = new Cons();
            Console.WriteLine("Cons.alpha = " + Cons.GetAlpha());
            Console.WriteLine("Cons.beta = " + ob.GetBetta());
        }
    }
}
