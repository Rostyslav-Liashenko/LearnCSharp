using System;

namespace TestDifferentFeatures
{
    public class Product
    {
        protected string Name;
        protected double Price;
        protected DateTime DataCreate;

        public Product(string name, double price, int year, int month, int day)
        {
            this.Name = name;
            this.Price = price;
            DataCreate = new DateTime(year,month,day);
        }

        public virtual string GetState()
        {
            if (DateTime.Now < DataCreate.AddYears(1))
                return "The product is suitable";
            else
                return "The product is not suitable";
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("name = " + Name + "\nprice = " + Price);
            Console.WriteLine("Date Create = " + DataCreate + "\nstate = " + GetState());
            Console.WriteLine();
        }
    }
}
