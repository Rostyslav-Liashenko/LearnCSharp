using System;

namespace LearnGeneralization
{
    class DefaultDemo
    {
       static void Main()
       {
           Test<MyClass> x = new Test<MyClass>();
           if (x.obj == null)
               Console.WriteLine("Variable x.obj have value null");
           Test<int> y = new Test<int>();
           if (y.obj == 0)
               Console.WriteLine("Variable y have value 0");
       }
    }
}
