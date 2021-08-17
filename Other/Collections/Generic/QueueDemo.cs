using System;
using System.Collections.Generic;

namespace LearnCollections
{
    class QueueDemo
    {
        static void Main()
        {
            Queue<double> q = new Queue<double>();
            q.Enqueue(98.6);
            q.Enqueue(212.0);
            q.Enqueue(32.0);
            q.Enqueue(3.1416);
            double sum = 0.0;
            Console.Write("Queue have: ");
            while (q.Count > 0)
            {
                double val = q.Dequeue();
                Console.Write(val + " ");
                sum += val;
            }
            Console.WriteLine("\nSum = " + sum);
        }
    }
}
