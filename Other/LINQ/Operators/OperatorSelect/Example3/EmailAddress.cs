namespace LearnLINQ
{
    public class EmailAddress
    {
        public string Name { get; set;}
        public string Address { get; set; }

        public EmailAddress(string n, string a)
        {
            Name = n;
            Address = a;
        }
    }
}
