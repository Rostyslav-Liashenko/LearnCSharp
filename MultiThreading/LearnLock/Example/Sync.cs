namespace LearnThreading
{
    class Sync
    {
        static void Main()
        {
            int[] a = {1, 2, 3, 4, 5};
            MyThread mt1 = new MyThread("Child #1", a);
            MyThread mt2 = new MyThread("Child #2", a);
            MyThread mt3 = new MyThread("Child #3", a);
            MyThread mt4 = new MyThread("Child #4", a);
            mt1.Thrd.Join();
            mt2.Thrd.Join();
            mt3.Thrd.Join();
            mt4.Thrd.Join();
        }
    }
}
