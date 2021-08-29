using System;

namespace LearnSerelization
{
    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public string[] Sizes { get; set; }

        public override string ToString()
        {
            return $"Name: {Name},\nExpiry Date: {ExpiryDate},\nPrice: {Price},\n";
        }
    }
}
