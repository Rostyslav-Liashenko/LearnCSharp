using System;

namespace LearnCollections
{
    static class ItrNamed
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            foreach (char ch in mc.MyItr(7))
                Console.Write(ch + " ");
            Console.WriteLine();
            foreach(char ch in mc.MyItr(5, 12))
                Console.Write(ch + " ");
            Console.WriteLine();
        }
    }
}
