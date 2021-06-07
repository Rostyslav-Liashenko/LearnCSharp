using System;

namespace ConsoleApp6.TestVirtualOverride
{
    public class Derived2 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Method Who() in class Derived2");   
        }
    }
}
