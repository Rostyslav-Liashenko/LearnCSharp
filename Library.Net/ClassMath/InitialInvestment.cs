using System;

namespace LearnLibrary
{
    class InitialInvestment
    {
        static void Main()
        {
            decimal futVal;
            
            double intRate;
            double numYears;
            
            Console.Write("Input the future cost: ");
            try
            {
                futVal = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            Console.Write("Input the norm of income (ex : 0.085): ");
            try
            {
                intRate = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.Write("Input the count of age:");
            try
            {
                numYears = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }

            decimal initInvest = futVal / (decimal) Math.Pow(intRate + 1.0, numYears);
            Console.WriteLine("Requirements init capital: {0:C}", initInvest);
        }
    }
}
