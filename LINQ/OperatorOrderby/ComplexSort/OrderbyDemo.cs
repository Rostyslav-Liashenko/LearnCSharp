using System;
using System.Linq;

namespace LearnLINQ
{
    class OrderbyDemo
    { 
        static void Main()
        {
            Account[] accounts =
            {
                new Account("Том", "Smith", "132CK", 100.23),
                new Account("Том", "Smith", "132CD", 10000.0),
                new Account("Ralf", "Floyd", "436CD", 1923.85),
                new Account("Ralf", "Floyd", "454MM", 987.132),
                new Account("Ted", "Crammer", "897CD", 3223.19),
                new Account("Ralf", "Floyd", "434CK", -123.32),
                new Account("Sara", "Smith", "543MM", 5017.40),
                new Account("Sara", "Smith", "547CD", 34955.79),
                new Account("Sara", "Smith", "843CK", 345.00),
                new Account("Albert", "Smith", "445CK", 345.00),
                new Account("Albert", "Crammer", "968MM", 5146.67),
                new Account("Carl", "Smith", "078CD", 15345.99),
                new Account("Jeny", "Floyd", "108CK", 10.98)
            };
            var accInfo = from acc in accounts
                orderby acc.LastName, acc.FirstName, acc.Balance
                select acc;
            string str = "";
            Console.WriteLine("Sort");
            foreach (var acc in accInfo)
            {
                if (str != acc.FirstName)
                {
                    Console.WriteLine();
                    str = acc.FirstName;
                }
                Console.WriteLine("{0}, {1}\t Number: {2}, {3,10:C}",
                    acc.LastName,acc.FirstName,acc.AccountNumber, acc.Balance);
            }
            Console.WriteLine();
        }
    }
}
