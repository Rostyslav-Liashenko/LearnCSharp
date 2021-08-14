>using System;
using System.Collections;

namespace LearnCollections
{
    class HashTableDemo
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("building","living quarters");
            ht.Add("car","transport");
            ht.Add("book","kit typed word");
            ht.Add("Apple","fruit");
            ht["tractor"] = "agriculture machine";
            ICollection c = ht.Keys;
            foreach (string str in c)
                Console.WriteLine(str + ": " + ht[str]);    
        }
    }
}
