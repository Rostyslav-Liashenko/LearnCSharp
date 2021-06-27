using PracticeAbstract.Animals;

namespace PracticeAbstract
{
    public class Veterinarian
    {
        public string Name { get; private set; }

        public Veterinarian(string name)
        {
            Name = name;
        }

        public void TreatAnimal(Animal animal)
        {
            animal.Eat();
            animal.MakeNoise();
            animal.Sleep();
        }
    }
}