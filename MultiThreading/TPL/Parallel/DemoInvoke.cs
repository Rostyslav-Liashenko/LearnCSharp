using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoInvoke
    {

        static void MyMeth()
        {
            Console.WriteLine("MyMeth is start.");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In method MyMeth i = " + i);
            }
            Console.WriteLine("MyMeth is end.");
        }

        static void MyMeth2()
        {
            Console.WriteLine("MyMeth is start.");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In method MyMeth2 i = " + i);
            }
            Console.WriteLine("MyMeth2 is end.");
        }
        
        static void Main()
        {
            Console.WriteLine("Main thread is start.");
            Parallel.Invoke(MyMeth, MyMeth2);
            Console.WriteLine("Main thread is finished.");
        }
    }
}
