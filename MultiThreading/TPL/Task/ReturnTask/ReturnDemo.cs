using System;
using System.Threading.Tasks;

namespace LearnTPL
{
    class ReturnDemo
    {
        static bool MyTask()
        {
            return true;
        }

        static int SumIt(object v)
        {
            int x = (int) v;
            int sum = 0;
            for (; x > 0; x--)
                sum += x;
            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Main thread is begin");
            Task<bool> tsk = Task<bool>.Factory.StartNew(MyTask);
            Console.WriteLine("Result after execution task MyTask: " + tsk.Result);
            Task<int> tsk2 = Task<int>.Factory.StartNew(SumIt, 3);
            Console.WriteLine("Result after execution task SumIt: " + tsk2.Result);
            tsk.Dispose();
            tsk2.Dispose();
            Console.WriteLine("Main thread is finished");
        }
    }
}
