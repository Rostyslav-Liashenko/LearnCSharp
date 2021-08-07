using System;
using System.Threading;

namespace LearnCSharpFramework
{
    class ResetAbortDemo
    {
        static void Main(string[] args)
        {
            MyThread mt1 = new MyThread("Мой Поток");

            Thread.Sleep(1000);

            Console.WriteLine("Прерывание потока.");
            mt1.Thrd.Abort(0);

            Thread.Sleep(1000);

            Console.WriteLine("Прерывание потока.");
            mt1.Thrd.Abort(100);

            mt1.Thrd.Join();

            Console.WriteLine("Основной поток прерван.");

            Console.ReadLine();
        }
    }
}
