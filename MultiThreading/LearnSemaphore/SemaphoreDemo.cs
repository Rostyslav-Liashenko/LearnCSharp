namespace LearnThreading
{
    class SemaphoreDemo
    {
        static void Main()
        {
            MyThread mt1 = new MyThread("Thread #1");
            MyThread mt2 = new MyThread("Thread #2");
            MyThread mt3 = new MyThread("Thread #3");

            mt1.Thrd.Join();
            mt2.Thrd.Join();
            mt3.Thrd.Join();
        }
    }
}
