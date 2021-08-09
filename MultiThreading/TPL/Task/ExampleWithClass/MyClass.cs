using System;
using System.Threading;

namespace LearnTPL
{
    public class MyClass
    {
        public void MyTask()
        {
            Console.WriteLine("MyTask() is start");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In method MyTask(), count = " + i);
            }

            Console.WriteLine("MyTask() is end");
        }
    }
}
