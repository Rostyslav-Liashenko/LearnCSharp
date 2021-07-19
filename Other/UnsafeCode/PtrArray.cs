using System;

namespace LearnPointer
{
    class PtrArray
    {
        static unsafe void Main()
        {
            int[] nums = new int[10];
            fixed (int* p = &nums[0], p2 = nums)
            {
                if (p == p2)
                    Console.WriteLine("Value p and p2 is equals");
            }
        }
    }
}
