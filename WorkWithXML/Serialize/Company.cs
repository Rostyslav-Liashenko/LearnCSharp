using System;

namespace LearnXML
{
    [Serializable]
    
    public class Company
    {
        public string Name { get; set; }

        public Company(string name)
        {
            Name = name;
        }

        public Company()
        { }
        
    }
}
