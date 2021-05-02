using System;

namespace ConsoleApp1
{
    class RelLogOps
    {
        static void Main()
        {
            int i = 10, j = 11;
            if (i < j) Console.WriteLine("i < j");
            if (i <= j) Console.WriteLine("i <= j");
            if (i != j) Console.WriteLine("i != j");
            if (i == j) Console.WriteLine("Not work!");
            if (i >= j) Console.WriteLine("Not work!");
            if (i > j) Console.WriteLine("Not work!");
            bool b1 = true;
            bool b2 = false;
            if (b1 & b2) Console.WriteLine("Not work!");
            if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) = true");
            if (b1 | b2) Console.Write("b1 | b2 = true");
            if (b1 ^ b2) Console.WriteLine("b1 ^ v2 = true");
        }
    }
}
