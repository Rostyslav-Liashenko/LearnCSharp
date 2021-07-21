using System;
using System.Linq;

namespace LearnLINQ
{
    class ExtMethods
    {
        static void Main()
        {
            int[] nums = {3, 1, 2, 5, 4};
            Console.WriteLine("Min = " + nums.Min());
            Console.WriteLine("Max = " + nums.Max());
            Console.WriteLine("First value = " + nums.First());
            Console.WriteLine("Last value = " + nums.Last());
            Console.WriteLine("Sum = " + nums.Sum());
            Console.WriteLine("Average = " + nums.Average());
            if (nums.All(n => n > 0))
                Console.WriteLine("All value > 0");
            if (nums.Any(n => n % 2 == 0))
                Console.WriteLine("Have even value");
            if (nums.Contains(3))
                Console.WriteLine("Array have value = 3");
        }
    }
}
