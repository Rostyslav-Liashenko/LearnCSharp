using System;

namespace ConsoleApp4
{
    public class MyClass
    {
        private int a;
        private int b;

        public static MyClass Factory(int i, int j)
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
