using System;
using System.Collections.Generic;

namespace LearnCollections
{
    class DictionaryDemo
    {
        static void Main()
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict.Add("Batler, John", 73000);
            dict.Add("Shwarz, Sara", 59000);
            dict.Add("Paik, Tomas", 45000);
            dict.Add("Frank, Ed", 99000);
            ICollection<string> c = dict.Keys;
            foreach (var str in c)
                Console.WriteLine("{0}, salary: {1:C}",str,dict[str]);
        }
    }
}
