using System;

namespace ConsoleApp4
{
    public class Overload2
    {
        public void MyMeth(int x)
        {
            Console.WriteLine("In method MyMeth(int): " + x);
        }

        public void MyMeth(byte x)
        {
            Console.WriteLine("In method MyMeth(byte): " + x);
        }
        
        public void MyMeth(double x)
        {
            Console.WriteLine("In method MyMethod(double): " + x);
        }
    }
}
