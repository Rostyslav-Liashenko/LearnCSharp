namespace ConsoleApp5.ComplexClass.Details
{
    public class Engine
    {
        private int power;
        private string company;

        public Engine(int power, string company)
        {
            this.company = company;
            this.power = power;
        }
        
        public override string ToString()
        {
            return "Power: " + power + "\ncompany: " + company + "\n";
        }
    }
}