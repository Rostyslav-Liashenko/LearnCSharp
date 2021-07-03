using System;

namespace PracticeAbstract.Animals
{
    public class Cat : Animal
    {
        public Cat(string food, string location) : base(food, location)
        { }

        public override void MakeNoise()
        {
           Console.WriteLine("Mya-Mya"); 
        }

        public override void Eat()
        {
            Console.WriteLine("Cat is eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Cat is sleeping");
        }
    }
}