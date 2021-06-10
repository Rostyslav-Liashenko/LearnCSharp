using System;

namespace ConsoleApp5.Reader
{
    public class Reader
    {
        private string FIO;
        private int nomReaderTicket;
        private string faculty;
        private DateTime birthday;

        public Reader(string f, int nom, string faculty, int year, int month, int day)
        {
            FIO = f;
            nomReaderTicket = nom;
            this.faculty = faculty;
            birthday = new DateTime(year, month, day);
        }

        public void TakeBook(int countBook)
        {
            Console.WriteLine(FIO + " take " + countBook + " books");
        }

        public void TakeBook(params string[] books)
        {
            Console.Write(FIO + " takes ");
            foreach (string book in books)
                Console.Write(book + ", ");
            Console.WriteLine();
        }

        public void TakeBook(params Book[] books)
        {
            Console.Write(FIO + " takes ");
            foreach (Book book in books)
                Console.WriteLine(book.Title + " Author: " + book.Author + " ");
            Console.WriteLine();
        }

        public void ReturnBook(params Book[] books)
        {
            Console.Write(FIO + " returns ");
            foreach (Book book in books)
                Console.WriteLine(book.Title + " Author: " + book.Author + " ");
            Console.WriteLine();
        }
        
        public void ReturnBook(int countBook)
        {
            Console.WriteLine(FIO + " returns " + countBook + " books");
        }

        public override string ToString()
        {
            return "FIO:" + FIO + "\nNumber reader ticket: " + nomReaderTicket +
                   "\nfaculty: " + faculty + "\nbirthday: " + birthday.Year + "/" + birthday.Month + "/" +
                   birthday.Day +
                   "\n\n";
        }
        
    }
}
