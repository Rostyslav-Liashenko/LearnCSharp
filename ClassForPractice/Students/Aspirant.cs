using ConsoleApp5.TestInheritance;

namespace ConsoleApp5
{
    public class Aspirant : Student
    {
        private const int IncreasedScholarships = 200;
        private const int Scholarships = 80;
        
        public Aspirant(string fn, string ln, string gr, double avg) : base(fn,ln,gr,avg)
        {}
        
        public Aspirant()
        {}
        public override double GetScholarship()
        {
            if (averageMark == 5.0)
                return IncreasedScholarships;
            else
                return Scholarships;
        }
    }
}
