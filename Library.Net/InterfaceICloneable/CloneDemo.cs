using System;

namespace LearnLibrary
{
    class CloneDemo
    {
        static void Main()
        {
            Test ob1 = new Test(10, 20);
            ob1.Show("ob1");
            Console.WriteLine("Make clone");
            Test ob2 = (Test) ob1.Clone();
            ob2.Show("ob2");
            Console.WriteLine("change value object ob1");
            ob1.o.A = 99;
            ob1.B = 88;
            ob1.Show("ob1");
            ob2.Show("ob2");
        }
    }
}
