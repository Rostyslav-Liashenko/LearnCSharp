namespace ConsoleApp5.ComplexClass.Professions
{
    public class Driver : Person.Person
    {
        private int experience;

        public Driver() : base(" ", 0)
        {
            experience = 0;
        }
        
        public Driver(string FIO, int age, int experience) : base(FIO, age)
        {
            this.experience = experience;
        }

        public override string ToString()
        {
            return base.ToString() + "experience:" + experience + " years\n";
        }
    }
}