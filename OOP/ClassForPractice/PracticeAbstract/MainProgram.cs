using System;
using PracticeAbstract.Animals;

namespace PracticeAbstract
{
    class MainProgram
    {
        static void Main()
        {
            Veterinarian someVeterinarian = new Veterinarian("Petro");
            Animal[] animals =
            {
                new Cat("fish", "room"),
                new Dog("bone", "house"),
                new Horse("grass", "field")
            };
            foreach (Animal animal in animals)
            {
                someVeterinarian.TreatAnimal(animal);
                Console.WriteLine();
            }
        }
    }
}