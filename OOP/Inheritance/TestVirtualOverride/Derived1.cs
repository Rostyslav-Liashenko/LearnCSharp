using System;

namespace ConsoleApp6.TestVirtualOverride
{
    public class Derived1 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Method Who() in class Derived1");
        }
    }
}
