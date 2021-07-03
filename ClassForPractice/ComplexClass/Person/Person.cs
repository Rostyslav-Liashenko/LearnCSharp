using System;

namespace ConsoleApp5.ComplexClass.Person
{
    public class Person
    {
        private string _fullName;
        private int _age;

        public Person()
        {
            _fullName = "?";
            _age = 0;
        }

        public Person(string fullName, int age)
        {
            this._fullName = fullName;
            this._age = age;
        }

        public void Talk()
        {
            Console.WriteLine(_fullName + " talking...");
        }

        public void Move()
        {
            Console.WriteLine(_fullName + " moving");
        }

        public override string ToString()
        {
            return "FIO: " + _fullName + "\nAge: " + _age + "\n";
        }
    }
}