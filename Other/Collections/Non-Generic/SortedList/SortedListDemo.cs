using System;
using System.Collections;

namespace LearnCollections
{
    class SortedListDemo
    {
        static void Main()
        {
            SortedList sl = new SortedList();
            sl.Add("building","living quarters");
            sl.Add("car","transport");
            sl.Add("book","kit typed word");
            sl.Add("Apple","fruit");
            sl["tractor"] = "agriculture machine";
            ICollection c = sl.Keys;
            foreach (string str in c)
                Console.WriteLine(str + ": " + sl[str]);
            Console.WriteLine();
            Console.WriteLine("Content list by index");
            for (int i = 0; i < sl.Count; i++)
                Console.WriteLine(sl.GetByIndex(i));
            Console.WriteLine();
            Console.WriteLine("Integer index elements list");
            foreach (string str in c)
                Console.WriteLine(str + ": " + sl.IndexOfKey(str));  
        }
    }
}
