using System;

namespace LearnException
{
    class ExcTest
    {
        private static void GenException()
        {
            int[] nums = new int[4];
            Console.WriteLine("Before generation exception");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}] = {1}",i,nums[i]);
            }
        }
        
        
        static void Main()
        {
            try
            {
                ExcTest.GenException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range exception");
            }
            Console.WriteLine("After block try");
        }
    }
}
