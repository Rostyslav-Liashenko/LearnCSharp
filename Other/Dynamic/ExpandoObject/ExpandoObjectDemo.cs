using System;
using System.Collections.Generic;

namespace LearnDynamic
{
    class ExpandoObjectDemo
    {
        static void Main()
        {
            dynamic viewBag = new System.Dynamic.ExpandoObject();
            viewBag.Name = "Tom";
            viewBag.Age = 46;
            viewBag.Language = new List<string> {"english", "german", "french"};
            Console.WriteLine($"{viewBag.Name} - {viewBag.Age}");
            foreach (var lan in viewBag.Language)
                Console.WriteLine(lan);
            viewBag.IncrementAge = (Action<int>) (x => viewBag.Age += x);
            viewBag.IncrementAge(6);
            Console.WriteLine($"{viewBag.Name} - {viewBag.Age}");
        }
    }
}
