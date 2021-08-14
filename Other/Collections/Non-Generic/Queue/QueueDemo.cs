using System;
using System.Collections;

namespace LearnCollections
{
    class QueueDemo
    {
        static void ShowQueue(Queue q)
        {
            Console.Write("Content queue: ");
            foreach (int i in q)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        
        static void ShowEnq(Queue q, int a)
        {
            q.Enqueue(a);
            Console.WriteLine("In queue: Enqueue(" + a + ")");
            ShowQueue(q);
        }

        static void ShowDeq(Queue q)
        {
            Console.Write("extract from queue: Dequeue -> ");
            int a = (int) q.Dequeue();
            Console.WriteLine(a);
            ShowQueue(q);
        }
        
        static void Main()
        {
            Queue q = new Queue();
            ShowEnq(q, 22);
            ShowEnq(q,65);
            ShowEnq(q, 91);
            ShowDeq(q);
            ShowDeq(q);
            ShowDeq(q);
            try
            {
                ShowDeq(q);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Queue is empty.");
            }
        }
    }
}
