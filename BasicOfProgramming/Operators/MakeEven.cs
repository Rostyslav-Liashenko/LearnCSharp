using System;

namespace ConsoleApp1
{
    class MakeEven
    {
        static void Main()
        {
            for (ushort i = 1; i <= 10; i++)
            {
                ushort num = i;
                Console.WriteLine("num: " + num);
                num = (ushort) (num & 0xFFFE);
                Console.WriteLine("New num: " + num);
            }
        }
    }
}
