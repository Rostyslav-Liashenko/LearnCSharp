namespace LearnEvent
{
    public delegate void MyEventHandler();
    
    class EventDemo3
    { 
        public static void Main()
        {
            MyEvent evt = new MyEvent();
            X o1 = new X(1);
            X o2 = new X(2);
            X o3 = new X(3);
            evt.SomeEvent += o1.XHandler;
            evt.SomeEvent += o2.XHandler;
            evt.SomeEvent += o3.XHandler;
            evt.OnSomeEvent();
        }
    }
}
