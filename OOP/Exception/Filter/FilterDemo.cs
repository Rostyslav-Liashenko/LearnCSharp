using System;

namespace LearnFeatures
{
    static class FilterDemo
    {
        static void Main()
        {
            int x = 1;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException) when (x == 0 && y == 0)
            {
                Console.WriteLine("Infinity");
            }
            catch (DivideByZeroException ex)
            {
               Console.WriteLine(ex.Message); 
            }
        }
    }
}
