using System;

namespace LearnPartical
{
    class DemoReadOnly
    {
        static void Main(string[] args)
        {
            int[] source = new int[MyClass.SIZE];
            int[] target = new int[MyClass.SIZE];
            for (int i = 0; i < MyClass.SIZE; i++)
                source[i] = i;
            foreach (var i in source)
                Console.Write(i + " ");
            Console.WriteLine();
            for (int i = MyClass.SIZE - 1, j = 0; i > 0; i--, j++)
                target[j] = source[i];
            foreach(int i in target)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
