using System;

namespace LearnGeneralization
{
    public class MyClass<T> : IMyContraVarGenIF<T>
    {
        public void Show(T x)
        {
            Console.WriteLine(x);
        }
    }
}