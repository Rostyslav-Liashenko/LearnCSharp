using System;

namespace ConsoleApp6.TestProtected
{
    public class A
    {
        protected int i;
        protected int j;

        public void Set(int a, int b)
        {
            i = a;
            j = b;
        }

        public void Show()
        {
            Console.WriteLine(i + " " + j);
        }
        
    }
}
