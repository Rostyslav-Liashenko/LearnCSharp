using System;

namespace ConsoleApp3
{
    class LengthDemo
    {
        static void Main()
        {
            int[] nums = new int[10];
            Console.WriteLine("Length of array = "+ nums.Length);
            for (int i = 0; i < nums.Length; i++)
                nums[i] = i * i;
            Console.WriteLine("Nums:");
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");
        }
    }
}
