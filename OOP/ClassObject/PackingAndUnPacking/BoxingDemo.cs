using System;

namespace ConsoleApp6
{
    class BoxingDemo
    {
        static void Main()
        {
            int x = 10;
            object obj = x; // packing
            int y = (int) obj; // unpacking
            Console.WriteLine(y);
        }
    }
}
