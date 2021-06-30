using System;

namespace LearnEvent
{
    class AccountDemo
    {
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);    
        }
        
        public static void Main()
        {
            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            acc.Put(20);
            Console.WriteLine($"Summa in account: {acc.Sum}");
            acc.Take(70);
            Console.WriteLine($"Summa in account: {acc.Sum}");
            acc.Take(180);
            Console.WriteLine($"Summa in account: {acc.Sum}");
        }
    }
}
