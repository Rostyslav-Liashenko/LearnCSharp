namespace LearnGeneralization
{
    public class Supplier : IPhoneNumber
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Supplier(string n, string num)
        {
            Name = n;
            Number = num;
        }
        
        // some code
    }
}