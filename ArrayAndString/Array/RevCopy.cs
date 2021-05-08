using System;

namespace ConsoleApp3
{
    class RevCopy
    {
        static void Main()
        {
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];
            for (int i = 0; i < nums1.Length; i++)
                nums1[i] = i;
            Console.WriteLine("Nums1: ");
            for (int i = 0; i < nums1.Length; i++)
                Console.Write(nums1[i] + " ");
            Console.WriteLine();
            if (nums2.Length >= nums1.Length)
                for (int i = 0, j = nums2.Length - 1; i < nums1.Length ; i++, j--)
                    nums2[i] = nums1[j];
            Console.WriteLine("Reverse:");
            for (int i = 0; i < nums2.Length; i++)
                Console.Write(nums2[i] + " ");
        }
    }
}
