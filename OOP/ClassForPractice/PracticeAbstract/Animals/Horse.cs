using System;

namespace PracticeAbstract.Animals
{
    public class Horse : Animal
    {
        public Horse(string food, string location) : base(food, location)
        { }
        public override void MakeNoise()
        {
            Console.WriteLine("Pr-Pr"); 
        }

        public override void Eat()
        {
            Console.WriteLine("Horse is eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Horse is sleeping");
        }
    }
}