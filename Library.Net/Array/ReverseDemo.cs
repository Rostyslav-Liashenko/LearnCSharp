using System;

namespace LearnLibrary
{
    class ReverseDemo
    {
        static void ShowArray<T>(T[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void Main()
        {
            int[] nums = {1, 2, 3, 4, 5,};
            Console.WriteLine("Source array:");
            ShowArray(nums);
            Array.Reverse(nums);
            Console.WriteLine("Reverse array");
            ShowArray(nums);
            Array.Reverse(nums,1,3);
            Console.WriteLine("Partical  reverse array");
            ShowArray(nums);
            Console.WriteLine();
        }
    }
}
