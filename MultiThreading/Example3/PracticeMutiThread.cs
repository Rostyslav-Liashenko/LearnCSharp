using System;
using System.Threading;

namespace LearnThreading
{
    class PracticeMultiThread
    {
        private static void MySum(object obj)
        {
            int[] array = (int[]) obj;
            int sum = 0;
            foreach (var el in array)
                sum += el;
            Console.WriteLine("Sum = " + sum);
        }

        private static void MyProduct(object obj)
        {
            int prod = 1;
            int[] array = (int[]) obj;
            foreach (var el in array)
                prod *= el;
            Console.WriteLine("Prod = " + prod);
        }
        
        static void Main()
        {
            Console.WriteLine("Input the count of array: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            Console.WriteLine("Input the element: ");
            for (int i = 0; i < array.Length; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
            Thread mt1 = new Thread(MySum);
            Thread mt2 = new Thread(MyProduct);
            mt1.Priority = ThreadPriority.Highest;
            mt1.Start(array);
            mt2.Start(array);
            mt1.Join();
            mt2.Join();
        }
    }
}
