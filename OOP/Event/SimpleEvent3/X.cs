using System;

namespace LearnEvent
{
    public class X
    {
        private int id;

        public X(int x)
        {
            id = x;
        }

        public void XHandler()
        {
            Console.WriteLine("Event received object " + id);
        }
    }
}
