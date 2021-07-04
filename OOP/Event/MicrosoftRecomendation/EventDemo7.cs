using System;

namespace LearnEvent
{ 
    static class EventDemo7
    {
        static void Handler(object source, EventArgs arg)
        {
            Console.WriteLine("Event is happened");
            Console.WriteLine("Sources:" + source);
        }
        static void Main()
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += Handler;
            evt.OnSomeEvent();
        }
    }
}
