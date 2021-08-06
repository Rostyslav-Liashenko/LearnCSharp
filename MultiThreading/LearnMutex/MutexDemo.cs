using System.Threading;

namespace LearnThreading
{
    class MutexDemo
    {
        static void Main()
        {
            IncThread mt1 = new IncThread("Increment", 5);
            Thread.Sleep(500);
            DecThread mt2 = new DecThread("Decrement", 5);
            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}
