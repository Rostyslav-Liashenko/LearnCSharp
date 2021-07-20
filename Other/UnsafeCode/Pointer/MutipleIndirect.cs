using System;

namespace LearnPointer
{
    class MultipleIndirect
    {
        static unsafe void Main()
        {
            int x = 10;
            int* p = &x;
            int** q = &p;
            Console.WriteLine(**q);
        }
    }
}
