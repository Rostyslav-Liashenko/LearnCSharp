using System;
using System.Collections.Generic;

namespace LearnCollections
{
    static class InventoryList
    {
        static void Main()
        {
            List<Inventory> inv = new List<Inventory>();
            inv.Add(new Inventory("Axe", 5.95, 3));
            inv.Add(new Inventory("Hummer", 8.29, 2));
            inv.Add(new Inventory("Bed", 3.50, 4));
            inv.Add(new Inventory("Drill", 19.88, 8));
            Console.WriteLine("Items");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);
        }
    }
}
