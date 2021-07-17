using System;
using System.Linq;

namespace LearnLINQ
{
    class GroupDemo
    {
        static void Main()
        {
            Person[] persons =
            {
                new Person("Anastasiya","Kurakinus"),
                new Person("Diana","Liashenko"),
                new Person("Volodymur","Kurakinus"),
                new Person("Rostyslav","Liashenko")
            };
            var query = from person in persons
                group person by person.LastName;
            foreach (var family in query)
            {
                Console.WriteLine("Family: " + family.Key);
                foreach (var member in family)
                    Console.WriteLine("{0} {1}", member.Name, member.LastName);
                Console.WriteLine();
            }
        }
    }
}
