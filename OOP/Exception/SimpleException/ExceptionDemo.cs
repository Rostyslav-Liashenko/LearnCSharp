using System;

namespace LearnException
{
    class ExceptionDemo
    {
        static void Main()
        {
            int[] nums = new int[4];
            try
            {
                Console.WriteLine("Before generating exception");
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}] = {1}", i, nums[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
            Console.WriteLine("After block try");
        }
    }
}
