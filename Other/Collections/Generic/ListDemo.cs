using System;
using System.Collections.Generic;

namespace LearnCollections
{
    class ListDemo
    {
        static void ShowList<T>(List<T> lst)
        {
            Console.Write("Current state: ");
            foreach (var t in lst)
                Console.Write(t + " ");
            Console.WriteLine();
        }
        
        static void Main()
        {
            List<char> lst = new List<char>();
            lst.Add('C');
            lst.Add('A');
            lst.Add('E');
            lst.Add('B');
            lst.Add('D');
            lst.Add('F');
            Console.WriteLine("Count = {0}, Capacity = {1}", lst.Count, lst.Capacity);
            ShowList(lst);
            lst.Remove('F');
            lst.Remove('A');
            Console.WriteLine("Count = {0}, Capacity = {1}", lst.Count, lst.Capacity);
            for (int i = 0; i < 20; i++)
                lst.Add((char) ('a' + i));
            Console.WriteLine("Count = {0}, Capacity = {1}", lst.Count, lst.Capacity);
            ShowList(lst);
            Console.WriteLine("Change first 3 elements");
            lst[0] = 'X';
            lst[1] = 'Y';
            lst[2] = 'Z';
            ShowList(lst);
            
        }
    }
}
