using System;

namespace LearnFeatures
{
    static class RecordDemo
    {
        static void Main()
        {
            var person = new PersonRec("Tom", 36);
            var person2 = new PersonRec("John", 26);
            // instead Equals you can use operator == or !=
            Console.WriteLine(person.Equals(person2) ? "person1 == person2" : "person1 != person2");
            var person3 = person with {Name = "Bob"};
            Console.WriteLine(person3);
            (string userName, int userAge) = person2;
            Console.WriteLine($"User name = {userName}");
            Console.WriteLine($"User age = {userAge}");
        }
    }
}
