using System;

namespace ConsoleApp3
{
    public class MyClass
    {
        private int a;
        private int b;

        public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;
            return t;
        }
        
        public void Show()
        {
            Console.WriteLine("a and b: " + a +" " + b);
        }
        
    }
}
