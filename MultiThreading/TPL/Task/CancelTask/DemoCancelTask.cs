using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoCancelTask
    {
        static void MyTask(Object ct)
        {
            CancellationToken cancelTok = (CancellationToken) ct;
            cancelTok.ThrowIfCancellationRequested();
            Console.WriteLine("MyTask() is start");
            for (int count = 0; count < 10; count++)
            {
                if (cancelTok.IsCancellationRequested)
                {
                    Console.WriteLine("Task cancellation request received");
                    cancelTok.ThrowIfCancellationRequested();
                }
                Thread.Sleep(500);
                Console.WriteLine("In method MyTask() count = " + count);
            }
            Console.WriteLine("MyTask is end");
        }

        static void Main()
        {
            Console.WriteLine("Main thread is start.");
            CancellationTokenSource cancelTokSrc = new CancellationTokenSource();
            Task tsk = Task.Factory.StartNew(MyTask, cancelTokSrc.Token, cancelTokSrc.Token);
            Thread.Sleep(2000);
            try
            {
                cancelTokSrc.Cancel();
                tsk.Wait();
            }
            catch (AggregateException)
            {
                if (tsk.IsCanceled)
                    Console.WriteLine("\nTask is canceled");
            }
            finally
            {
                tsk.Dispose();
                cancelTokSrc.Dispose();
            }
            Console.WriteLine("Main thread is end");
        }
    }
}
