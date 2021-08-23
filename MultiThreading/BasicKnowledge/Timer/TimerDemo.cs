using System;
using System.Threading;

namespace LearnFeatures
{
    static class TimerDemo
    {

        public static void Count(object obj)
        {
            int x = (int) obj;
            for (int i = 1; i < 9; i++, x++)
                Console.WriteLine($"{x * i}");
        }
        
        static void Main()
        {
            int num = 0;
            TimerCallback tm = Count;
            Timer timer = new Timer(tm, num, 0, 2000);
            Console.ReadLine();
        }
    }
}
