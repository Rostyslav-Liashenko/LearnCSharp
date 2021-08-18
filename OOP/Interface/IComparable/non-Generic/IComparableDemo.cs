using System;
using System.Collections;

namespace LearnCollections
{
    static class IComparableDemo
    {
        static void Main()
        {
            ArrayList inv = new ArrayList();
            inv.Add(new Inventory("Axe", 5.95, 3));
            inv.Add(new Inventory("Hummer", 8.29, 2));
            inv.Add(new Inventory("Bed", 3.50, 4));
            inv.Add(new Inventory("Drill", 19.88, 8));
            Console.WriteLine("Items");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);
            Console.WriteLine();
            inv.Sort();
            Console.WriteLine("Items");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);
        }
    }
}
