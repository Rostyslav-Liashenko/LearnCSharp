using System;

namespace LearnEventPractice
{
    public class Phone
    {
        private string number;

        public Phone()
        {
            number = "";
        }

        public Phone(string number)
        {
            this.number = number;
        }

        public event EventHandler<MyEventArgs> Call;
        public event EventHandler<MyEventArgs> Discharge;
        public event EventHandler<MyEventArgs> Charge;

        public void OnCall(string name)
        {
            MyEventArgs evt = new MyEventArgs {Message = name};
            Call?.Invoke(this,evt);
        }

        public void OnDischarge()
        {
            Discharge?.Invoke(this,new MyEventArgs());
        }

        public void OnCharge()
        {
            Charge?.Invoke(this,new MyEventArgs());
        }
        
    }
}
