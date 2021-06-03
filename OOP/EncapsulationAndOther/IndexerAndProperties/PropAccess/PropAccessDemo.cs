using System;

namespace ConsoleApp4
{
    class PropAccessDemo
    {
        static void Main()
        {
            PropAccess ob = new PropAccess();
            Console.WriteLine("Begin value ob.MyProp " + ob.MyProp);
            ob.IncrProp();
            Console.WriteLine("Value ob.MyProp after increment " + ob.MyProp);
        }
    }
}
