using System;
using System.Threading;

namespace LearnCSharpFramework
{
    public class MyThread
    {
        public Thread Thrd;

        public MyThread(string name)
        {
            Thrd = new Thread(Run) { Name = name };
            Thrd.Start();
        }

        void Run()
        {

            Console.WriteLine(Thrd.Name + " started.");

            for (int i = 1; i <= 1000; i++)

            {
                try
                {
                    Console.Write(i + " ");
                    if (i % 10 == 0)
                    {
                        Console.WriteLine();
                        Thread.Sleep(250);
                    }
                }
                catch (ThreadAbortException exc)
                {
                    if ((int)exc.ExceptionState == 0)
                    {
                        Console.WriteLine("Прерывание потока отменено! Код завершения " + exc.ExceptionState);
                        Thread.ResetAbort();
                    }
                    Console.WriteLine("Поток прерван, код завершения " + exc.ExceptionState);
                }

                
            }
            Console.WriteLine(Thrd.Name + " fin.");

        }
    }
}
