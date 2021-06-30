namespace LearnEvent
{
    public delegate void MyEventHandler();
    
    public class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
        }
    }
}
