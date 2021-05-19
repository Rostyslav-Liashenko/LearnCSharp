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
            Console.WriteLine();
            Console.Write("Operator relation");
            a = new ThreeD(5, 6, 7);
            b = new ThreeD(10, 10, 10);
            c = new ThreeD(1, 2, 3);
            ThreeD d = new ThreeD(6, 7, 5);
            Console.Write("Coordinate point a:");
            a.Show();
            Console.Write("Coordinate point b:");
            b.Show();
            Console.Write("Coordinate point c:");
            c.Show();
            Console.Write("Coordinate point d:");
            d.Show();
            Console.WriteLine();
            if (a > c) Console.WriteLine("a > c true");
            if (a < c) Console.WriteLine("a < c true");
            if (a > b) Console.WriteLine("a > b true");
            if (a < b) Console.WriteLine("a < b true");
            if (a > d) Console.WriteLine("a > d true");
            else if (a < d) Console.WriteLine("a < d true");
            else Console.WriteLine("Point a and d places in same distance from {0,0,0}");
            a = new ThreeD(5, 6, 7);
            b = new ThreeD(10, 10, 10);
            c = new ThreeD(0, 0, 0);
            Console.WriteLine(a ? "a is true" : "a is false");
            Console.WriteLine(b ? "b is true" : "b is false");
            Console.WriteLine(c ? "c is true" : "c is false");

        }
    }
}
