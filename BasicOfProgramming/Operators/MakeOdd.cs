using System;

namespace ConsoleApp1
{
    class MakeOdd
    {
        static void Main()
        {
            ushort num;
            for (ushort i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("num:" + num);
                num = (ushort) (num | 1);
                Console.WriteLine("num after | :" + num);
            }
        }
    }
}
