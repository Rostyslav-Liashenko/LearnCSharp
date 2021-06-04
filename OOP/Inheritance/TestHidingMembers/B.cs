using System;

namespace ConsoleApp6.HidingMembers
{
    public class B:A
    {
        private new int i;

        public B(int a, int b)
        {
            base.i = a;
            i = b;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine("member i in class B: " + i);
        }
        
    }
}
