using System;

namespace ConsoleApp6.HidingMembers
{
    public class A
    {
        protected int i = 0;

        public void Show()
        {
            Console.WriteLine("member i in base class A:" + i);
        }
        
    }
}
