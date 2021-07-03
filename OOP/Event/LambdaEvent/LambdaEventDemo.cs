using System;

namespace LearnEvent
{
    public delegate void MyEventHandler(int n);
    
    class LambdaEventDemo
    { 
        public static void Main()
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += (int n) => Console.WriteLine("Event is received. Value = " + n);
            evt.OnSomeEvent(1);
            evt.OnSomeEvent(2);
        }
    }
}
