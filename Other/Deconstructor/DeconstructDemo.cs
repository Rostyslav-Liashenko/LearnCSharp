using System;

namespace LearnFeatures
{
    static class DeconstructDemo
    {
        static void Main()
        {
            Person person = new Person{Name = "Tom", Age = 18};
            (string name, int age) = person;
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}
