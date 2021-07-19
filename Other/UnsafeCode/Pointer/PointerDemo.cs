using System;

namespace LearnPointer
{
    class PointerDemo
    {
        static unsafe void Main()
        {
            int count = 99;
            int* p = &count;
            Console.WriteLine("Value : " + *p);
            *p = 10;
            Console.WriteLine("New value: " + *p);
        }
    }
}
