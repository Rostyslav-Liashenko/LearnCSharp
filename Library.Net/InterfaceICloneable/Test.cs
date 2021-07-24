using System;

namespace LearnLibrary
{
    public class Test : ICloneable
    {
        public X o;
        public int B { get; set; }

        public Test(int x, int y)
        {
            o = new X(x);
            B = y;
        }

        public void Show(string name)
        {
            Console.Write("Value object " + name + ": ");
            Console.WriteLine("o.a {0}, b: {1}",o.A,B);
        }

        public object Clone()
        {
            Test temp = new Test(o.A, B);
            return temp;
        }
        
    }
}
