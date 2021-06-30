using System;

namespace LearnEvent
{
    class EventDemo
    {
        static void Handler()
        {
            Console.WriteLine("An happened event");    
        }
        
        public static void Main()
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += Handler;
            evt.OnSomeEvent();
        }
    }
}w
