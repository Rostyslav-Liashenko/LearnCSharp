using System;
using System.IO;
using Newtonsoft.Json; // nuget 

namespace LearnSerelization
{
    static class WriteJsonInFileDemo
    {
        static void Main()
        {
            Product product = new Product
            {
                Name = "Apple", 
                ExpiryDate = new DateTime(2009, 12, 29),
                Price = 3.99M,
                Sizes =  new[] {"Small", "Medium", "Large" }
            };
            // write in file product.json
            JsonSerializer serializer = new JsonSerializer();
            using JsonWriter writer = new JsonTextWriter(new StreamWriter("product.json"));
            serializer.Serialize(writer, product);
        }
    }
}
