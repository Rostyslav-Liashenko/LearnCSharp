using System;

namespace LearnInterface
{
    class SeriesDemo2
    {
        static void Main()
        {
            ByTwos twoOb = new ByTwos();
            Primes primeOb = new Primes();
            ISeries ob;

            for (int i = 0; i < 5; i++)
            {
                ob = twoOb;
                Console.WriteLine("Next even number = " + ob.GetNext());
                ob = primeOb;
                Console.WriteLine("Next prime number = " + ob.GetNext());
            }
        }
    }
}
