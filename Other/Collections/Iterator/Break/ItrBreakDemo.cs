using System;

namespace LearnCollections
{
    static class ItrBreakDemo
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            foreach (char ch in mc)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
    }
}
