using System;

namespace LearnLibrary
{
    class PredDemo
    {
        static void ShowArray<T>(T[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        
        static void Main()
        {
            int[] nums = {1, 4, -1, 5, -9};
            ShowArray(nums);
            if (Array.Exists(nums, (num) => num < 0))
            {
                Console.WriteLine("Array nums have negative value");
                int x = Array.Find(nums, (num) => num < 0);
                Console.WriteLine("First negative value: " + x);
            }
            else 
                Console.WriteLine("In array nums not have negative value");
        }
    }
}
