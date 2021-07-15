using System;

namespace LearnGeneralization
{
    public class VarianceDemo
    {
        public static void Main()
        {
            IMyCoVarGenIF<Alpha> AlphaRef = new MyClass<Alpha>(new Alpha("Alpha #1"));
            Console.WriteLine("AlphaRef: " + AlphaRef.GetObject().GetName());
            AlphaRef = new MyClass<Beta>(new Beta("Beta #1"));
            Console.WriteLine("AlphaRef: " + AlphaRef.GetObject().GetName());
        }
    }
}