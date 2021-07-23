using System;

namespace LearnLibrary
{
    class CopyDemo
    {
        static void ShowArray<T>(T[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void Main()
        {
            int[] source = {1, 2, 3, 4, 5};
            int[] target = {11, 12, 13, 14, 15};
            int[] source2 = {-1, -2, -3, -4, -5};
            Console.WriteLine("Source array");
            ShowArray(source);
            Console.WriteLine("Target array");
            ShowArray(target);
            Array.Copy(source, target, source.Length);
            source[0] = 1234;
            Console.WriteLine("Target after copy");
            ShowArray(target);
            Array.Copy(source2, 2, target, 3, 2); 
            Console.WriteLine("Target array after parical copy");
            ShowArray(target);
        }
    }
}
