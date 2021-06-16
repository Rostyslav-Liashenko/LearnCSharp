using System;

namespace LearnException
{
    class RangeArrayDemo
    {
        public static void Main()
        {
            try
            {
                RangeArray ra = new RangeArray(-5, 5);
                RangeArray ra2 = new RangeArray(1, 10);
                for (int i = -5; i <= 5; i++)
                    ra[i] = i;
                Console.WriteLine("Length if ra:" + ra.Length);
                Console.WriteLine("Content ra:");
                ra.Show();
                for (int i = 1; i <= 10; i++)
                    ra2[i] = i;
                Console.WriteLine("Length of ra2:" + ra2.Length);
                Console.WriteLine("Content ra2:");
                ra2.Show();
                
            }
            catch (RangeArrayException exc)
            {
                Console.WriteLine(exc);
            }
            Console.WriteLine("Generation exception");
            try
            {
                RangeArray ra3 = new RangeArray(100, -10);
            }
            catch (RangeArrayException exc)
            {
                Console.WriteLine(exc);
            }

            try
            {
                RangeArray ra3 = new RangeArray(-2, 2);
                for (int i = -2; i <= 2; i++)
                    ra3[i] = i;
                Console.WriteLine("Content ra3:");
                for (int i = -2; i <= 10; i++)
                    Console.Write(ra3[i] + " ");
                Console.WriteLine();
            }
            catch (RangeArrayException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
