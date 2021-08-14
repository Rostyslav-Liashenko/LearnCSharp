using System;
using System.Collections;

namespace LearnCollections
{
    class StackDemo
    {

        static void ShowStack(Stack st)
        {
            Console.Write("Content stack: ");
            foreach (int i in st)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        static void ShowPush(Stack st, int a)
        {
            st.Push(a);
            Console.WriteLine("Push in stack: Push(" + a + ")");
            ShowStack(st);
        }

        static void ShowPop(Stack st)
        {
            Console.Write("Pop from stack: Pop -> ");
            int a = (int) st.Pop();
            Console.WriteLine(a);
            ShowStack(st);
        }
        
        static void Main()
        {
            Stack st = new Stack();
            foreach (int i in st)
                Console.Write(i + " ");
            Console.WriteLine();
            ShowPush(st,22);
            ShowPush(st, 65);
            ShowPush(st, 91);
            ShowPop(st);
            ShowPop(st);
            ShowPop(st);
            try
            {
                ShowPop(st);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }
}
