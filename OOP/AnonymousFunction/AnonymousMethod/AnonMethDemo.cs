using System;

namespace LearnAnonymoss
{
    delegate void CountIt();
    
    class AnonMethDemo
    {
        static void Main()
        {
            CountIt count = delegate
            {
                for (int i = 0; i <= 5; i++)
                    Console.Write(i + " ");
            };
            count();
            Console.WriteLine();
            count = delegate
            {
                for (int i = 0; i <= 10; i+=2)
                    Console.Write(i + " ");
            };
            count();
        }
    }
}
