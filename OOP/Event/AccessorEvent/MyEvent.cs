using System;

namespace LearnEvent
{
    public class MyEvent
    {
        private MyEventHandler[] evnt = new MyEventHandler[3];
        public event MyEventHandler SomeEvent
        {
            add
            {
                int i;
                for (i = 0; i < evnt.Length; i++)
                    if (evnt[i] == null)
                    {
                        evnt[i] = value;
                        break;
                    }
                if (i == evnt.Length) 
                    Console.WriteLine("List is full");
            }
            remove
            {
                int i;
                for (i = 0; i < evnt.Length; i++)
                    if (evnt[i] == value)
                    {
                        evnt[i] = null;
                        break;
                    }
                if (i == evnt.Length) Console.WriteLine("Handler event not found");
            }
        }

        public void OnSomeEvent()
        {
            for (int i = 0; i < evnt.Length; i++)
                if (evnt[i] != null)
                    evnt[i]();
        }
    }
}
