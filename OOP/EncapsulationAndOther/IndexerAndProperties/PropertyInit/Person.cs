namespace LearnFeatures
{
    public class Person
    {
        public string Name { get; init; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Jack";
            Age = 18;
        }
        
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
