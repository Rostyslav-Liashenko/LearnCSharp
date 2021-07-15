using System;

namespace LearnGeneralization
{
    class GenMethDemo
    {
       static void Main()
       {
           int[] nums = {1, 2, 3,};
           int[] nums2 = new int[4];
           Console.WriteLine("Array nums: ");
           ArrayUtils.ShowArray(nums);
           ArrayUtils.CopyInsert(99, 2, nums, nums2);
           Console.WriteLine("Array nums2: ");
           ArrayUtils.ShowArray(nums2);
           string[] strs = { "Generalization","very","effective"};
           string[] strs2 = new string[4];
           Console.WriteLine("Array strs");
           ArrayUtils.ShowArray(strs);
           ArrayUtils.CopyInsert<string>("In C#", 1, strs, strs2);
           Console.WriteLine("Array strs2");
           ArrayUtils.ShowArray(strs2);
       }
    }
}
