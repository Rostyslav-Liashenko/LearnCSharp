using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        public Thread Thrd { get; set; }
        private TickTock ttOb;

        public MyThread(string name, TickTock tt)
        {
            Thrd = new Thread(Run);
            ttOb = tt;
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            if (Thrd.Name == "Tick")
            {
                for (int i = 0; i < 5; i++)
                    ttOb.Tick(true);
                ttOb.Tick(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    ttOb.Tock(true);
                ttOb.Tock(false);
            }
            
        }
    }
}
