using System;

namespace LearnFeatures
{
    static class InterpolationDemo
    {
        static void Main()
        {
            var person = new {Name = "Tom", Age = 18};
            long number = 19876543210;
            Console.WriteLine($"{number: +# ### ## ##}");
            Console.WriteLine($"Name: {person.Name, -10} Age: {person.Age}"); // after
            Console.WriteLine($"Name: {person.Name, 5} Age: {person.Age}"); // before
        }
    }
}
