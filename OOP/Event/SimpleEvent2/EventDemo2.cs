using System;

namespace LearnEvent
{
    public delegate void MyEventHandler();
    
    class EventDemo2
    {
        static void Handler()
        {
            Console.WriteLine("Event received object class EventDemo");
        }
        
        public static void Main()
        {
            MyEvent evt = new MyEvent();
            X xOb = new X();
            Y yOb = new Y();

            evt.SomeEvent += Handler;
            evt.SomeEvent += xOb.Xhandler;
            evt.SomeEvent += yOb.Yhandler;
            evt.OnSomeEvent();
            Console.WriteLine();
            evt.SomeEvent -= xOb.Xhandler;
            evt.OnSomeEvent();
        }
    }
}
