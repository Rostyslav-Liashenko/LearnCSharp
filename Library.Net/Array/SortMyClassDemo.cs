using System;

namespace LearnLibrary
{
    class SortMyClassDemo
    {
        static void ShowArray<T>(T[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void Main()
        {
            MyClass[] nums =
            {
                new MyClass(5),
                new MyClass(2),
                new MyClass(3),
                new MyClass(4),
                new MyClass(1)
            };
            ShowArray(nums);
            Array.Sort(nums);
            ShowArray(nums);
            MyClass x = new MyClass(2);
            int idx = Array.BinarySearch(nums, x);
            Console.WriteLine("index element array with object MyClass(2): " + idx);
        }
    }
}
