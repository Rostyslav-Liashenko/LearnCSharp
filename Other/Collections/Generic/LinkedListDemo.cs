using System;
using System.Collections.Generic;

namespace LearnCollections
{
    class LinkedListDemo
    {
        static void Main()
        {
            LinkedList<char> ll = new LinkedList<char>();
            Console.WriteLine("Count = " + ll.Count);
            Console.WriteLine("Add in linked list 5 elements");
            ll.AddFirst('A');
            ll.AddFirst('B');
            ll.AddFirst('C');
            ll.AddFirst('D');
            ll.AddFirst('E');
            Console.WriteLine("Count = " + ll.Count);
            LinkedListNode<char> node;
            Console.Write("manual processing... ");
            for (node = ll.First; node != null; node = node.Next)
                Console.Write(node.Value + " ");
            Console.WriteLine();
            Console.WriteLine("With help foreach");
            foreach (var ch in ll)
                Console.Write(ch + " ");
            Console.WriteLine();
            Console.Write("Reverse direction ");
            for (node = ll.Last; node != null; node = node.Previous)
                Console.Write(node.Value + " ");
            Console.WriteLine();
            Console.WriteLine("Remove 2 elements");
            ll.Remove('C');
            ll.Remove('A');
            Console.WriteLine("Count = " + ll.Count);
            foreach (var ch in ll)
                Console.Write(ch + " ");
            Console.WriteLine();
            ll.AddLast('X');
            ll.AddLast('Y');
            ll.AddLast('Z');
            Console.Write("Content after input element: ");
            foreach (char ch in ll)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
    }
}
