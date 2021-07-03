using System;

namespace LearnEvent
{
    public delegate void MyEventHandler();
    
    class EventDemo5
    { 
        public static void Main()
        {
            MyEvent evt = new MyEvent();
            W wOb = new W();
            X xOb = new X();
            Y yOb = new Y();
            Z zOb = new Z();
            Console.WriteLine("add in list event");
            evt.SomeEvent += wOb.Whandler;
            evt.SomeEvent += xOb.Xhandler;
            evt.SomeEvent += yOb.Yhandler;
            // fill list
            evt.SomeEvent += zOb.Zhandler;
            evt.OnSomeEvent();
            Console.WriteLine();
            Console.WriteLine("Remove handler xOb.Xhandler");
            evt.SomeEvent -= xOb.Xhandler;
            evt.OnSomeEvent();
            Console.WriteLine();
            Console.WriteLine("Try remove handler xOb.Xhandler again");
            evt.SomeEvent -= xOb.Xhandler;
            evt.OnSomeEvent();
            Console.WriteLine();
            Console.WriteLine("Add handler object class Z");
            evt.SomeEvent += zOb.Zhandler;
            evt.OnSomeEvent();
        }
    }
}
