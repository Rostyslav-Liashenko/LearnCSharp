using System;

namespace ConsoleApp4
{
    class UseOptArgs
    {
        static void Display(string str, int start = 0, int stop = -1)
        {
            if (stop < 0)
                stop = str.Length;
            
            if (stop > str.Length | start > stop | start < 0)
                return ;
            for (int i = start; i < stop; i++)
                Console.Write(str[i]);
            Console.WriteLine();
        }
        static void Main()
        {
            Display("It is simple test");
            Display("It is simple test", 2);
            Display("It is simple test",10,14);
        }
    }
}
