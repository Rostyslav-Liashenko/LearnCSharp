using System;

namespace ConsoleApp1
{
    class SwitchDemo
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("i = 0");
                        break;
                    case 1:
                        Console.WriteLine("i = 1");
                        break;
                    case 2:
                        Console.WriteLine("i = 2");
                        break;
                    case 3:
                        Console.WriteLine("i = 3");
                        break;
                    case 4:
                        Console.WriteLine("i = 4");
                        break;
                    default:
                        Console.WriteLine("i >= 5");
                        break;
                }
            }
        }
    }
}
