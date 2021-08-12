using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LearnPLINQ
{
    class PLINQACancelDemo
    {
        static void Main()
        {
            CancellationTokenSource cancelTokSrc = new CancellationTokenSource();
            int[] data = new int[10000000];
            for (int i = 0; i < data.Length; i++)
                data[i] = i;
            data[1000] = -1;
            data[14000] = -2;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;
            var negatives = from val in data.AsParallel()
                    .WithCancellation(cancelTokSrc.Token)
                where val < 0
                select val;
            Task cancelTsk = Task.Factory.StartNew(
                () =>
                {
                    Thread.Sleep(100);
                    cancelTokSrc.Cancel();
                });
            try
            {
                foreach (var v in negatives)
                    Console.Write(v + " ");
            }
            catch (OperationCanceledException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (AggregateException exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                cancelTsk.Wait();
                cancelTokSrc.Dispose();
                cancelTsk.Dispose();
            }
            Console.WriteLine();
        }
    }
}
