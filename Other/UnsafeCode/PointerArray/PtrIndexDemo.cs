using System;

namespace LearnPointer
{
    class PtrIndexDemo
    {
        static unsafe void Main()
        {
            int[] nums = new int[10];
            Console.WriteLine("Indexing a pointer as an array.");
            fixed (int* p = nums)
            {
                for (int i = 0; i < 10; i++)
                    p[i] = i;
                for (int i = 0; i < 10; i++)
                    Console.WriteLine("p[{0}]: {1}",i,p[i]);
            }
            Console.WriteLine("Using arithmetic operations on pointers.");
            fixed (int* p = nums)
            {
                for (int i = 0; i < 10; i++)
                    *(p + i) = i;
                for (int i = 0; i < 10; i++)
                    Console.WriteLine("p[{0}] {1}",i,*(p+i));
            }
        }
    }
}
