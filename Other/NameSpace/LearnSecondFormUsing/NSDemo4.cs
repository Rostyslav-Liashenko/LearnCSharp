using System;
using MyCounter = Counter.CountDown;


namespace LearnNameSpace
{
    class NSDemo4
    {
        static void Main(string[] args)
        {
            MyCounter cd1 = new MyCounter(10);
            int i;
            do
            {
                i = cd1.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
            MyCounter cd2 = new MyCounter(20);
            do
            {
                i = cd2.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
            cd2.Reset(4);
            do
            {
                i = cd2.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
        }
    }
}
