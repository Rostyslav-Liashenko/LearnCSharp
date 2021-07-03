namespace LearnEvent
{
    public class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            SomeEvent?.Invoke();
        }
    }
}
