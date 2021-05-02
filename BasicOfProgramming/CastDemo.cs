using System;

namespace ConsoleApp1
{
    class CastDemo
    {
        static void Main(string[] args)
        {
            double x, y;
            byte b;
            int i;
            char ch;
            uint u;
            short s;
            long l;
            x = 10.0;
            y = 3.0;
            i = (int) (x / y);
            Console.WriteLine("x / y = " + i);
            Console.WriteLine();
            i = 255;
            b = (byte) i;
            Console.WriteLine("b = 255: " + b);
            i = 257;
            b = (byte) i;
            Console.WriteLine("b = 257: " + b);
            Console.WriteLine();
            u = 32000;
            s = (short) u;
            Console.WriteLine("s = 32000: " + s);
            u = 64000;
            s = (short) u;
            Console.WriteLine("s = 64000: " + s);
            Console.WriteLine();

            l = 64000;
            u = (uint) l;
            Console.WriteLine ("u = 64000: " + u);
            l = -12;
            u = (uint) l;
            Console.WriteLine("y = -12: " + u);
                              Console.WriteLine();
            b = 88;
            ch = (char) b;
            Console.WriteLine("ch = 88: " + ch);
        }
    }
}
