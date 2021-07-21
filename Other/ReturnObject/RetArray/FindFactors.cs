using System;

namespace ConsoleApp3
{
    class FindFactors
    {
        static void Main()
        {
            Factor f = new Factor();
            int numFactors;
            int[] factors = f.FindFactors(1000, out numFactors);
            for (int i = 0; i < numFactors; i++)
                Console.WriteLine(factors[i] + " ");
        }
    }
}
