using System;
using System.Linq;

namespace LearnLINQ
{
    static class ExceptDemo
    {
        static void Main()
        {
            string[] soft = {"Microsoft", "Google", "Apple" };
            string[] hard = {"Apple", "IBM", "Samsung"};
            var result = soft.Except(hard);
            foreach (var s in result)
                Console.WriteLine(s);
        }
    }
}
