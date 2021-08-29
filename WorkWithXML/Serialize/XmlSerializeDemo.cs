using System;
using System.IO;
using System.Xml.Serialization;

namespace LearnXML
{
    static class XmlSerializeDemo
    {
        static void Main()
        {
            Person[] people = new Person[]
            {
                new Person("Tom", 29, new Company("Microsoft")),
                new Person("Bill", 25, new Company("Apple"))
            };

            XmlSerializer formatter = new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, people);
            }

            using (FileStream fs = new FileStream("people.xml",FileMode.OpenOrCreate))
            {
                Person[] newPeople = (Person[]) formatter.Deserialize(fs);
                if (newPeople != null)
                    foreach (Person p in newPeople)
                        Console.WriteLine($"Name: {p.Name} --- Age: {p.Age} --- Company: {p.Company.Name}");
            }
        }
    }
}
