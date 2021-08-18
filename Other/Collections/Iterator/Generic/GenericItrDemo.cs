using System;

namespace LearnCollections
{
    static class GenericItrDemo
    {
        static void Main()
        {
            int[] nums = {4, 3, 6, 4, 7, 9};
            MyClass<int> mc = new MyClass<int>(nums);
            foreach (int x in mc)
                Console.Write(x + " ");
            Console.WriteLine();
            bool[] bVals = {true, true, false, true};
            MyClass<bool> mc2 = new MyClass<bool>(bVals);
            foreach (bool b in mc2)
                Console.Write(b + " ");
        }
    }
}
