namespace LearnGeneralization
{
    public class Friend : IPhoneNumber
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public bool IsWorkNumber { get; set; }
        public Friend(string n, string num, bool wk)
        {
            Name = n;
            Number = num;
            IsWorkNumber = wk;
        }
        
    }
}