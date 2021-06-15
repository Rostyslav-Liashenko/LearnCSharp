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
        
        public static void Main()
        {
            try
            {
                GenException();
            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine("Standard message:");
                Console.WriteLine(exc);
                Console.WriteLine("Properties StackTrace" + exc.StackTrace);
                Console.WriteLine("Properties Message: " + exc.Message);
                Console.WriteLine("Properties TargetSite: " + exc.TargetSite);
            }    
        }
    }
}
