using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoCancelTask
    {


        static void MyTask(object tk)
        {
            CancellationToken cancelTok = (CancellationToken) tk;
            cancelTok.ThrowIfCancellationRequested();
            for (int i = 0; i < 10; i++)
            {
                cancelTok.ThrowIfCancellationRequested();
                Console.WriteLine("i = " + i);
                Thread.Sleep(500);
            }
        }
        
        static void Main()
        {
            Console.WriteLine("Main thread is begin.");
            CancellationTokenSource src = new CancellationTokenSource();
            Task tsk = Task.Factory.StartNew(MyTask, src.Token, src.Token);
            Thread.Sleep(2000);
            try
            {
                src.Cancel();
                tsk.Wait();
            }
            catch (AggregateException)
            {
                if (tsk.IsCanceled)
                    Console.WriteLine("Task MyTask is cancel.");
            }
            finally
            {
                src.Dispose();
                tsk.Dispose();
            }
            Console.WriteLine("Main thread is finished.");
        }
    }
}
