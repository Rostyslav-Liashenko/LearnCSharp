using System;

namespace ConsoleApp3
{
    class StackDemo
    {
        static void Main()
        {
            MyClass ob1 = new MyClass(4, 5);
            MyClass ob2 = new MyClass(6, 7);
            
            Console.Write("ob1: ");
            ob1.Show();
            
            Console.Write("ob2: ");
            ob2.Show();

            Console.WriteLine(ob1.SameAs(ob2) ? "ob1 and ob2 the same" : "ob1 and ob2 not same");
            Console.WriteLine();
            ob1.Copy(ob2);
            Console.WriteLine("After copying...");
            ob1.Show();
            Console.WriteLine(ob1.SameAs(ob2) ? "ob1 and ob2 the same" : "ob1 and ob2 not same");
        }
    }
}
