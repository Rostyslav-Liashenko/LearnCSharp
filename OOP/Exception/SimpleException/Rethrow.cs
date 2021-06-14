using System;

namespace LearnException
{
    class Rethrow
    {
        private static void GenException()
        {
            int[] numer = {4, 8, 16, 32, 64, 128, 256, 512};
            int[] denom = {2, 0, 4, 4, 0, 8};
            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine("{0} / {1} = {2}", numer[i], denom[i], numer[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divided by zero");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("No matching item found");
                    throw;
                }
            }
        }
        static void Main()
        {
            try
            {
                Rethrow.GenException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Program the end :)");
            }
        }
    }
}
