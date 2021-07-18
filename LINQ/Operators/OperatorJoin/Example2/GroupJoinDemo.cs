using System;
using System.Linq;

namespace LearnLINQ
{
    class GroupJoinDemo
    {
        static void Main()
        {
            string[] travelTypes =
            {
                "Air",
                "Nautical",
                "Terrestrial",
                "River"
            };
            Transport[] transports =
            {
                new Transport("bicycle", "Terrestrial"),
                new Transport("ballon","Air"),
                new Transport("boat","River"),
                new Transport("air-plane","Air"),
                new Transport("canoe","River"),
                new Transport("biplan","Air"),
                new Transport("car","Terrestrial"),
                new Transport("ship", "Nautical"),
                new Transport("train","Terrestrial")
            };
            var byHow = from how in travelTypes
                join trans in transports
                    on how equals trans.How
                    into lst
                select new {How = how, Tlist = lst};
            foreach (var t in byHow)
            {
                Console.WriteLine("Category <{0} transport> relative: ", t.How);
                foreach (var m in t.Tlist)
                    Console.WriteLine(" " + m.Name);
                Console.WriteLine();
            }
        }
    }
}
