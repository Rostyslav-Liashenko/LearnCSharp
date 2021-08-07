using System.Threading;

namespace LearnThreading
{
    class InterlockedDemo
    {
        static void Main()
        {
            IncThread mt1 = new IncThread("Increment");
            Thread.Sleep(100);
            DecThread mt2 = new DecThread("Decrement");
            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}
