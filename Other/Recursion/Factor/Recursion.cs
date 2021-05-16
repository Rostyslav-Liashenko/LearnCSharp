using System;

namespace ConsoleApp4
{
    class Recursion
    {
    
        static void Main()
        {
            Factor f = new Factor();
            Console.WriteLine("Factorial, calculated with help recursion method");
            Console.WriteLine("3! = " + f.FactR(3));
            Console.WriteLine("4! = " + f.FactR(4));
            Console.WriteLine("5! = " + f.FactR(5));
            Console.WriteLine();
            Console.WriteLine("Factorial, calculated with help loop method");
            Console.WriteLine("3! = " + f.FactI(3));
            Console.WriteLine("4! = " + f.FactI(4));
            Console.WriteLine("5! = " + f.FactI(5));
            Console.WriteLine();
        }
    }
}
