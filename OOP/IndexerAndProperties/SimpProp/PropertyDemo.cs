using System;

namespace ConsoleApp4
{
    class PropertyDemo
    {
        static void Main()
        {
            SimpProp ob = new SimpProp();
            Console.WriteLine("Begin value ob.MyProp " + ob.MyProp);
            ob.MyProp = 100;
            Console.WriteLine("Current value ob.MyProp " + ob.MyProp);
            Console.WriteLine("Try equals value -10 property ob.MyProp ");
            ob.MyProp = -10;
            Console.WriteLine("Current value ob.MyProp " + ob.MyProp);
        }
    }
}
