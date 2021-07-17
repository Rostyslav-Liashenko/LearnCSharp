namespace LearnLINQ
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        public string AccountNumber { get; private set;}

        public Account(string fn, string ln, string accnum, double b)
        {
            FirstName = fn;
            LastName = ln;
            AccountNumber = accnum;
            Balance = b;
        }
    }
}
