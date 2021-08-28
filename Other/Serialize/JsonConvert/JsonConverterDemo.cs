using System;
using Newtonsoft.Json; // nuget 

namespace LearnSerelization
{
    static class JsonConverterDemo
    {
        static void Main()
        {
            Product product = new Product
            {
                Name = "Apple", 
                ExpiryDate = new DateTime(2008, 12, 28),
                Price = 3.99M,
                Sizes =  new[] {"Small", "Medium", "Large" }
            };
            string output = JsonConvert.SerializeObject(product);
            Console.WriteLine(output);
            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine(deserializedProduct);
        }
    }
}
