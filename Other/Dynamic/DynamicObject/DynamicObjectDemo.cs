using System;

namespace LearnDynamic
{
    static class DynamicObjectDemo
    {
        static void Main()
        {
            dynamic person = new PersonObject();
            person.Name = "Tom";
            person.Age = 23;
            Func<int, int> Incr = delegate(int x) { 
                person.Age += x;
                return person.Age;
            };
            person.IncrementAge = Incr;
            Console.WriteLine($"{person.Name} - {person.Age}"); // Tom - 23
            person.IncrementAge(4);
            Console.WriteLine($"{person.Name} - {person.Age}"); // Tom - 27
        }
    }
}
