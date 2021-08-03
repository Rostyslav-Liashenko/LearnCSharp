using System;
using System.Threading;

namespace LearnThreading
{
    public class TickTock
    {
        private object lockOn = new object();

        public void Tick(bool running)
        {
            lock (lockOn)
            {
                if (!running)
                {
                    Monitor.PulseAll(lockOn);
                    return;
                }
                Console.Write("tik ");
                Monitor.Pulse(lockOn);
                Monitor.Wait(lockOn);
            }
        }

        public void Tock(bool running)
        {
            lock (lockOn)
            {
                if (!running)
                {
                    Monitor.PulseAll(lockOn);
                    return;
                }
            
                Console.WriteLine("tak ");
                Monitor.Pulse(lockOn);
                Monitor.Wait(lockOn);
            }
        }
    }
}
