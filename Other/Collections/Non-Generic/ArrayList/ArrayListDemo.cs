using System;
using System.Collections;

namespace LearnCollections
{
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Count = " + al.Count);
            Console.WriteLine();
            Console.WriteLine("Add new 6 elements");
            al.Add('C');
            al.Add('A');
            al.Add('E');
            al.Add('B');
            al.Add('D');
            al.Add('F');
            Console.WriteLine("Count = " + al.Count);
            Console.Write("Current state:");
            foreach (var t in al)
                Console.Write(t + " ");
            Console.WriteLine();
            al.Remove('F');
            al.Remove('A');
            Console.WriteLine("Count = " + al.Count);
            Console.Write("Current state: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine();
            Console.WriteLine("Add 20 elements");
            for (int i = 0; i < 20; i++)
                al.Add((char) ('a' + i));
            Console.WriteLine("Current Capacity: " + al.Capacity);
            Console.WriteLine("Count element after add 20 new: " + al.Count);
            Console.WriteLine("Current State");
            foreach (var c in al)
                Console.Write(c + " ");
            Console.WriteLine();
            Console.WriteLine("Change 3 first element");
            al[0] = 'X';
            al[1] = 'Y';
            al[2] = 'Z';
            Console.Write("Current State: ");
            foreach (var c in al)
                Console.Write(c + " ");
            Console.WriteLine();
        }
    }
}
