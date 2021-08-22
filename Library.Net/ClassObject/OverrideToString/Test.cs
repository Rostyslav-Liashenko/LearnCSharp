using System;
using ConsoleApp6.TestClassObject;

namespace ConsoleApp6
{
    class Test
    {
        static void Main()
        {
            MyClass ob1 = new MyClass();
            MyClass ob2 = new MyClass();
            MyClass ob3 = new MyClass();
            
            Console.WriteLine(ob1); // use override ToString()
            Console.WriteLine(ob2);
            Console.WriteLine(ob3);
        }
    }
}
