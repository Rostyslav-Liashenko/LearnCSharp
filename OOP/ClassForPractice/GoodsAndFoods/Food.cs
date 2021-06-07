using System;

namespace TestDifferentFeatures
{
    public class Food : Product
    {
        private DateTime expirationDate;

        public Food(string name, double price, int year, int month, int day, int tYear, int tMonth, int tDay)
            : base(name, price, year, month, day)
        {
            expirationDate = new DateTime(tYear, tMonth, tDay);
        }

        public override string GetState()
        {
            if (DataCreate < expirationDate) 
                return "The product is suitable";
            else 
                return "The product is subject to exclusion";
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Expiration date = " + expirationDate);
            Console.WriteLine();
        }
    }
}
