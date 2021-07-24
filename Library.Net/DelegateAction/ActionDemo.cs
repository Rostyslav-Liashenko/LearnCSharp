using System;

namespace LearnLibrary
{
    class ActionDemo
    {
        static void Show(MyClass o)
        {
            Console.Write(o.Num + " ");
        }

        static void Neg(MyClass o)
        {
            o.Num = -o.Num;
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
            Array.ForEach(nums,Show);
            Console.WriteLine();
            Array.ForEach(nums, x => x.Num = -x.Num);
            Console.Write("Array nums: ");
            Array.ForEach(nums,Show);
        }
    }
}
