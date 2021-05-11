using System;

namespace ConsoleApp3
{
    class DemoOut
    {
        static void Main()
        {
            Num ob = new Num();
            int lcf, gcf;
            if (ob.HasComFactor(231, 105, out lcf, out gcf))
            {
                Console.WriteLine("lcf (231 and 105) = " + lcf);
                Console.WriteLine("gcf (231 and 105) = " + gcf);
            }
            else
                Console.WriteLine("common factor (231 and 105) is none");

            if (ob.HasComFactor(35, 51, out lcf, out gcf))
            {
                Console.WriteLine("lcf (35 and 51) = " + lcf);
                Console.WriteLine("gcf (35 and 51) = " + gcf);
            }
            else 
                Console.WriteLine("common factor (231 and 105) is none");

        }
        
    }
}
