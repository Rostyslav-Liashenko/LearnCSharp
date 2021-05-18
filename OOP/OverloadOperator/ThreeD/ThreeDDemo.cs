using System;

namespace ConsoleApp4
{
    class ThreeDDemo
    {
        static void Main()
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c;
            Console.WriteLine("Coordinate point a:");
            a.Show();
            Console.WriteLine();
            Console.WriteLine("Coordinate point b:");
            b.Show();
            Console.WriteLine();
            c = a + b;
            Console.WriteLine("result of a + b:");
            c.Show();
            Console.WriteLine();
            c = a + b + c;
            Console.WriteLine("Result of a + b + c:");
            c.Show();
            Console.WriteLine();
            c = c - a;
            Console.WriteLine("Result of c - a:");
            c.Show();
            Console.WriteLine();
            c = c - b;
            Console.WriteLine("Result of c - b");
            c.Show();
            Console.WriteLine();
            c = -a;
            Console.WriteLine("Result of -a");
            c.Show();
            Console.WriteLine();
            c = a++;
            Console.WriteLine("if c = a++");
            Console.WriteLine("than coordinate point c:");
            c.Show();
            Console.WriteLine("coordinate point a:");
            a.Show();
            a = new ThreeD(1, 2, 3);
            Console.WriteLine("Set sources value point a:");
            a.Show();
            c = ++a;
            Console.WriteLine("\nIf c = ++a");
            Console.WriteLine("than coordinate point c :");
            c.Show();
            Console.WriteLine("coordinate point a:");
            a.Show();
            Console.WriteLine("Coordinate point b:");
            b.Show();
            c = b + 10;
            Console.WriteLine("Result of b + 10");
            c.Show();
            c = 10 + b;
            Console.WriteLine("Result of 10 + b");
            c.Show();
        }
    }
}
