using System;

namespace ConsoleApp3
{
    class ForeachDemo
    {
        static void Main()
        {
            int sum = 0;
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
                nums[i] = i;
            foreach (int x in nums)
            {
                Console.WriteLine("value element equals " + x);
                sum += x;
            }
            Console.WriteLine("Sum nums = " + sum);
        }
    }
}
