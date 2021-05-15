using System;

namespace ConsoleApp4
{
    class OptionArgDemo
    {
        static void OptArgMeth(int alpha, int beta = 10, int gamma = 20)
        {
            Console.WriteLine("It is argument:" + alpha + " " + beta + " " + gamma);
        }
        static void Main()
        {
            OptArgMeth(1,2,3);
            OptArgMeth(1,2);
            OptArgMeth(1);
        }
    }
}
