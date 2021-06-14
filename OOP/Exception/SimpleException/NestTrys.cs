using System;

namespace LearnException
{
    class NestTrys
    { 
        static void Main()
        {
            int[] number = {4, 8, 16, 32, 64, 128, 256, 512};
            int[] denom = {2, 0, 4, 4, 0, 8};
            try
            {
                for (int i = 0; i < number.Length; i++)
                {
                    try
                    {
                        Console.WriteLine(number[i] + "/" + denom[i] + " = " + number[i] / denom[i]);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("There were some exceptions");
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("No matching item not found\nThe end :)");
            }
        }
    }
}
