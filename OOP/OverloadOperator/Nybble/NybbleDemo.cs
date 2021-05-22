using System;

namespace ConsoleApp4
{
    class NybbleDemo
    {
        static void Main()
        {
            Nybble a = new Nybble(10);
            Nybble b = new Nybble(1);
            Nybble c = new Nybble();
            Console.WriteLine("a: " + (int) a);
            Console.WriteLine("b: " + (int) b);
            if (a < b)
                Console.WriteLine("a < b");
            c = a + b;
            Console.WriteLine("c = a + b: " + (int) c);
            c = a - b;
            Console.WriteLine("c = a - b:" + (int) c);
            Console.WriteLine();
            a += 5;
            Console.WriteLine("a after a+= 5: " + (int) a);
            Console.WriteLine();
            int t = a * 2 + 3;
            Console.WriteLine("t = a * 2 + 3: " + t);
            Console.WriteLine();
            a = 19;
            Console.WriteLine("a = 19: " + (int) a);
            Console.WriteLine("Controlled loop for with help class Nybble");
            for (a = 0; a < 10; a++)
                Console.Write((int) a + " ");
            Console.WriteLine();
        }
    }
}
