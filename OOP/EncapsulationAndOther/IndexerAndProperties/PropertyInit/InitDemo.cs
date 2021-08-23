using System;

namespace LearnFeatures
{
    static class InitDemo
    {
        static void Main()
        {
            Person person = new Person {Name = "Tom"};
            Person person2 = new Person();
            //person.Name = "Bob"; error
            //person2.Name = "Billy"; error
            Console.WriteLine(person);
            Console.WriteLine(person2);
        }
    }
}
