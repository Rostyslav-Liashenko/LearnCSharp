using System;

namespace PracticeAbstract.Animals
{
    public class Dog : Animal
    {
        public Dog(string food, string location) : base(food, location)
        { }
        public override void MakeNoise()
        {
            Console.WriteLine("gav-gav"); 
        }

        public override void Eat()
        {
            Console.WriteLine("Dog is eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
    }
}