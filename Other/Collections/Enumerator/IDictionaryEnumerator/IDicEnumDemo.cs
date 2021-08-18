using System;
using System.Collections;

namespace LearnCollections
{
    static class IDicEnumDemo
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            
            ht.Add("Ken","555-7756");
            ht.Add("Marry", "555-9876");
            ht.Add("Tom", "555-3456");
            ht.Add("Tod", "555-3452");
            IDictionaryEnumerator etr = ht.GetEnumerator();
            Console.WriteLine("Display information");
            while (etr.MoveNext())
                Console.WriteLine(etr.Entry.Key + " : " + etr.Entry.Value);
            Console.WriteLine();
            etr.Reset();
            while (etr.MoveNext())
                Console.WriteLine(etr.Key + ": " + etr.Value);
        }
    }
}
