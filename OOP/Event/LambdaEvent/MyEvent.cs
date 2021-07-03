namespace LearnEvent
{
    public class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent(int n)
        {
            SomeEvent?.Invoke(n);
        }
    }
}
