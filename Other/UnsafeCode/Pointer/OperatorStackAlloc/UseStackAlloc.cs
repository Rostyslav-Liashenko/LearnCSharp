using System;

namespace LearnPointer
{
    class UseStackAlloc
    {
        static unsafe void Main()
        {
            int* ptrs = stackalloc int[3];
            ptrs[0] = 1;
            ptrs[1] = 2;
            ptrs[2] = 3;
            for (int i = 0; i < 3; i++)
                Console.WriteLine(ptrs[i]);
        }
    }
}
