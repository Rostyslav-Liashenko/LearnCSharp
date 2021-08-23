using System;

namespace LearnFeatures
{
    public class Reader
    {
        private Lazy<Library> lib = new Lazy<Library>();

        public void ReadBook()
        {
            lib.Value.GetBook();
            Console.WriteLine("Read paper book");
        }

        public void ReadEbook()
        {
            Console.WriteLine("Read book in computer");
        }
        
    }
}
