using System;

namespace ConsoleApp4
{
    public class Overload
    {
        public void OvlDemo()
        {
            Console.WriteLine("Without parameter");
        }

        public void OvlDemo(int a)
        {
            Console.WriteLine("One parameter:" + a);
        }

        public int OvlDemo(int a, int b)
        {
            Console.WriteLine("Two parameter type int:" + a + " " + b);
            return a + b;
        }

        public double OvlDemo(double a, double b)
        {
            Console.WriteLine("Two parameter type double:" + a + " " + b);
            return a + b;
        }

    }
}
