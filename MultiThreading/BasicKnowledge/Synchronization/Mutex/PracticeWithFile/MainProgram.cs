using System.Threading;

namespace LearnThreading
{
    class MainProgram
    {
        public static Mutex myMutex = new Mutex();
        public static string nameOfFile = "test.data";
        static void Main()
        {
            MyThread mt1 = new MyThread("Writer #1", 2);
            MyThread mt2 = new MyThread("Writer #2", 5);
            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}
