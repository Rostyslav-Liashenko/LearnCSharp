using System;

namespace LearnStructure
{
    class StructDemo
    {
        static void Main()
        {
            Book book1 = new Book("Astrid Lingrend","Mio, mio my mio",2002);
            Book book2 = new Book();
            Book book3;
            Console.WriteLine(book1.Author + ", " + book1.Title + ", (c) " + book1.Copyright);
            Console.WriteLine();
            if (book2.Title == null)
                Console.WriteLine("Member book2.Title is empty");
            book2.Title = "Harry Potter";
            book2.Author = "Ruling";
            book2.Copyright = 2002;
            Console.WriteLine("Struct book2 have...");
            Console.WriteLine(book2.Author + ", " + book2.Title + ", (c) " + book2.Copyright);
            Console.WriteLine();
            book3.Author = "I";
            book3.Title = "Red storm";
            book3.Copyright = 2020; 
            Console.WriteLine(book3.Author + ", " + book3.Title + ", (c) " + book3.Copyright);
        }
    }
}
