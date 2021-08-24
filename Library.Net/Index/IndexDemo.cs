using System;

namespace LearnFeatures
{
    static class IndexDemo
    {
        static  void Main()
        {
            string[] people = { "Tom", "Bob", "Sam", "Kate", "Alica"};
            string selected1 = people[2]; // Sam
            string selected2 = people[^2]; // Kate
            Console.WriteLine(selected1);
            Console.WriteLine(selected2);
        }
    }
}
