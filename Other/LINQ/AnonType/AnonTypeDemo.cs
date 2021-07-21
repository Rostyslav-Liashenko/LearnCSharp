using System;
using System.Linq;

namespace LearnLINQ
{
    class AnonTypeDemo
    {
        static void Main()
        {
            Item[] items =
            {
                new Item("Axe",1424),
                new Item("Mouse",7892),
                new Item("Hammer", 8534),
                new Item("Shovel", 6411)
            };
            InStockStatus[] statusList =
            {
                new InStockStatus(7892,false),
                new InStockStatus(6411, true),
                new InStockStatus(1424,true),
                new InStockStatus(8534, true)
            };
            var inStockList = from item in items
                join entry in statusList
                    on item.ItemNumber equals entry.ItemNumber
                select new {item.Name, entry.InStock};
            Console.WriteLine("Item\tAvailability\n");
            foreach (var t in inStockList)
                Console.WriteLine("{0}\t{1}",t.Name,t.InStock);
            
        }
    }
}
