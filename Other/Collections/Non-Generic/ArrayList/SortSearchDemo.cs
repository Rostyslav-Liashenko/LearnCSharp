using System;
using System.Collections;

namespace LearnCollections
{
    class SortSearchDemo
    {
        static void ShowArrayList(ArrayList arrayList)
        {
            foreach (var t in arrayList)
                Console.Write(t + " ");
            Console.WriteLine();
        }
        
        static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add(55);
            al.Add(43);
            al.Add(-4);
            al.Add(88);
            al.Add(3);
            al.Add(19);
            ShowArrayList(al);
            al.Sort();
            ShowArrayList(al);
            Console.WriteLine("Index element 43: " + al.BinarySearch(43));
        }
    }
}
