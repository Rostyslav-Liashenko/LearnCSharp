namespace LearnEvent
{
    public delegate void MyEventHandler();
    
    class EventDemo4
    { 
        public static void Main()
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += X.XHandler;
            evt.OnSomeEvent();
        }
    }
}
