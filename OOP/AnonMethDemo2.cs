using System;

namespace LearnAnonymoss
{
    delegate void CountIt(int end);
    
    class AnonMethDemo2
    {
        static void Main()
        {
            CountIt count = delegate(int fin)
            {
                for (int i = 0; i <= fin; i++)
                    Console.Write(i + " ");
            };
            count(3);
            Console.WriteLine();
            count(5);
        }
    }
}
