using System;
using System.Linq;

namespace LearnLINQ
{
    class SelectDemo3
    { 
        static void Main()
        {
            ContactInfo[] contacts =
            {
                new ContactInfo("Herbert","Herb@HerbSchildt.com","555-1010"),
                new ContactInfo("Tom","Tom@HerbSchildt.com","555-1101"),
                new ContactInfo("Sara","Sara@HerbSchildt.com","555-0110")
            };
            var emailList = from entry in contacts
                select new EmailAddress(entry.Name, entry.Email);
            Console.WriteLine("List of Email persons");
            foreach (var e in emailList)
                Console.WriteLine(" {0}: {1}", e.Name,e.Address);
        }
    }
}
