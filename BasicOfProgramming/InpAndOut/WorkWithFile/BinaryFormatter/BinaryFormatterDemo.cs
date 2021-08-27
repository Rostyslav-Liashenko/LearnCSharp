using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LearnWorkWithFile
{
    static class BinaryFormatterDemo
    {
        static void Main()
        {
            Person person = new Person("Tom", 29);
            Console.WriteLine("object is create");
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("Object is serialize");
            }

            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person) formatter.Deserialize(fs);
                Console.WriteLine("Object is deserialize");
                Console.WriteLine($"Name: {newPerson.Name} --- Year: {newPerson.Year}");
            }
        }
    }
}
