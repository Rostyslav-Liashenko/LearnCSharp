using System;
using System.Text.Json;

namespace LearnSerelization
{
    static class JsonSerializerDemo
    {
        static void Main()
        {
            Person tom = new Person() {Name = "Tom", Age = 35};
            string json = JsonSerializer.Serialize(tom);
            Console.WriteLine(json);
            Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(restoredPerson?.Name);
        }
    }
}
