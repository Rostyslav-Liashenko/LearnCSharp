using System;

namespace LearnLibrary
{
    class BitConverterDemo
    {
        static void Main()
        {
            int x = 1456367;
            byte[] nums = BitConverter.GetBytes(x);
            Console.WriteLine("Number x: " + x);
            Console.WriteLine("Number x consist of byte: ");
            foreach (var t in nums)
                Console.Write(t + " ");
            Console.WriteLine();
        }
    }
}
