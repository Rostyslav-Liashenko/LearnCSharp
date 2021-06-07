using System;

namespace ConsoleApp3
{
    class AssignARef
    {
        static void Main()
        {
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];
            for (int i = 0; i < 10; i++)
                nums1[i] = i;
            for (int i = 0; i < 10; i++)
                nums2[i] = -i;
            Console.WriteLine("Array nums1: ");
            for (int i = 0; i < 10; i++)
                Console.Write(nums1[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Array nums2: ");
            for (int i = 0; i < 10; i++)
                Console.Write(nums2[i] + " ");
            Console.WriteLine();
            nums2 = nums1;
            Console.WriteLine("Nums2 after nums2 = nums1");
            for (int i = 0; i < 10; i++)
                Console.Write(nums2[i] + " ");
            Console.WriteLine();
            nums2[3] = 99;
            Console.WriteLine("Nums1 after nums2[3] = 99");
            for (int i = 0; i < 10; i++)
                Console.Write(nums1[i] + " ");
            Console.WriteLine();
        }
    }
}
