using System;

namespace ConsoleApp5
{
    class MainProgram
    {
        static int Main()
        {
            Sum a = new Sum(5, 8);
            Sum b = new Sum(6, 3);
            Console.WriteLine("Object sum a");
            a.Show();
            Console.WriteLine("object sum b");
            b.Show();
            Console.WriteLine("a + b");
            (a + b).Show();
            Console.WriteLine("a - b");
            (a - b).Show();
            Console.WriteLine("a * b");
            (a * b).Show();
            Console.WriteLine("a / b");
            (a / b).Show();
            Console.WriteLine(a > b ? "a > b" : "a < b");
            return 0;
        }
    }
}
