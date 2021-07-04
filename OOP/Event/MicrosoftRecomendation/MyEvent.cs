using System;

namespace LearnEvent
{
    public class MyEvent
    {
        public event EventHandler SomeEvent;

        public void OnSomeEvent()
        {
            SomeEvent?.Invoke(this,EventArgs.Empty);
        }
    }
}
