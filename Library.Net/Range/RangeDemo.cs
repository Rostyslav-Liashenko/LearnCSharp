using System;

namespace LearnFeatures
{
    static class RangeDemo
    {
        static  void Main()
        {
            string[] people = {"Tom", "Bob", "Sam", "Kate", "Alice"};
            string[] peopleRange = people[1..4];
            Console.WriteLine("First people range");
            foreach (var person in peopleRange)
                Console.Write(person + " ");
            Console.WriteLine();
            string[] peopleRange2 = people[^3..^1];
            Console.WriteLine("Second people range");
            foreach (var person in peopleRange2)
                Console.Write(person + " ");
            Console.WriteLine();
        }
    }
}
