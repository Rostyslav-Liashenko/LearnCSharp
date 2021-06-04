using System;

namespace ConsoleApp6.HidingMembers
{
    public class B:A
    {
        private new int i;

        public B(int b)
        {
            i = b;
        }

        public void Show()
        {
            Console.WriteLine("member i in class B:" + i);
        }
        
    }
}
