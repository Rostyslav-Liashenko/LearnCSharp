namespace ConsoleApp5.TestInheritance
{
    public class Student : Person
    {
        private const int IncreasedScholarships = 100;
        private const int Scholarships = 80;
        
        protected string Group;
        protected double averageMark;
        
        public Student(string fn, string ln, string gr, double avg)
        {
            FirstName = fn;
            LastName = ln;
            Group = gr;
            averageMark = avg;
        }
        
        public Student()
        { }

        public override string ToString()
        {
            return "First name: " + FirstName + "\nLast name: " + LastName
                   + "\nGroup:" + Group + " Average mark: " + averageMark
                   + "\nScholarship: " + GetScholarship();
        }

        public virtual double GetScholarship()
        {
            if (averageMark == 5.0)
                return IncreasedScholarships;
            else
                return Scholarships;
        }
    }
}
