using System;

namespace LearnCollections
{
    static class EnumeratorImplDemo
    {
        static void Main()
        {
            MyClass me = new MyClass();
            foreach (char ch in me)
                Console.Write(ch + " ");
            Console.WriteLine();
            foreach (char ch in me)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
    }
}
