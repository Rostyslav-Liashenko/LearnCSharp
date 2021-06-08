using System;

namespace LearnInterface
{
    class SeriesDemo
    {
        static void Main()
        {
            ByTwos ob = new ByTwos();
            
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next number = " + ob.GetNext());
            Console.WriteLine("Reset");
            ob.Reset();
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next number = " + ob.GetNext());
            Console.WriteLine("Begin from 100");
            ob.SetStart(100);
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next number = " + ob.GetNext());

            Console.WriteLine();
            Console.WriteLine("Series prime number");
            Primes pr = new Primes();
            for (int i = 0; i < 4; i++)
                Console.WriteLine("Next prime number = " + pr.GetNext());
        }
    }
}
