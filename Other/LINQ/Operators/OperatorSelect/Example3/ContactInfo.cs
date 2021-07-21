namespace LearnLINQ
{
    public class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ContactInfo(string n, string a, string p)
        {
            Name = n;
            Email = a;
            Phone = p;
        }
    }
}
