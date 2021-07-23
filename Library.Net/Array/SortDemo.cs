using System;

namespace LearnLibrary
{
    class SortDemo
    {
        static void ShowArray<T>(T[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        
        static void Main()
        {
            int[] nums = { 5, 4, 6, 3, 14, 9, 8, 17, 1, 24, -1, 0};
            Console.WriteLine("Sources Array");
            ShowArray(nums);
            Array.Sort(nums);
            Console.WriteLine("After sort");
            ShowArray(nums);
            int idx = Array.BinarySearch(nums, 14);
            Console.WriteLine("Index element with value 14 = " + idx);
        }
    }
}
