using System;

namespace LearnLibrary
{
    class CustomTimeAndDateFormatDemo
    {
        static void Main()
        {
            DateTime dt = DateTime.Now;
            
            Console.WriteLine("Time: {0:hh:m tt}", dt);
            Console.WriteLine("Time in 24-hours format: {0:HH:mm}", dt);
            Console.WriteLine("Date: {0:ddd MMM dd, yyyy}", dt);
            Console.WriteLine("Era: {0:gg}", dt);
            Console.WriteLine("Time in second: {0:HH:mm:ss tt}", dt);
            Console.WriteLine("Day of month: {0:m}", dt);
            Console.WriteLine("Minute in format m: {0:%m}", dt);
        }
    }
}
