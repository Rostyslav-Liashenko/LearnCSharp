namespace LearnGeneralization
{
    public class Friend : PhoneNumber
    {
        public bool IsWorkNumber { get; set; }
        public Friend(string n, string num, bool wk) : base(n,num)
        {
            IsWorkNumber = wk;
        }
        
    }
}