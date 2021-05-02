using System;

namespace ConsoleApp1
{
    class IsOdd
    {
        static void Main()
        {
            ushort num = 10;
            if ((num & 1) == 1)
                Console.WriteLine("Not working");
            num = 11;
            if ((num & 1) == 1)
                Console.WriteLine(num + " is odd number");
        }
    }
}
