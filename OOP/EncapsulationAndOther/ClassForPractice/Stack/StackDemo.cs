using System;

namespace ConsoleApp3
{
    class StackDemo
    {
        static void Main()
        {
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            Console.WriteLine("Push symbol A-J in stack stk1.");
            for(int i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));
            if (stk1.IsFull())
                Console.WriteLine("Stack stk1 is full");
            Console.WriteLine("Content stk1");
            while (!stk1.IsEmpty())
                Console.Write(stk1.Pop());
            Console.WriteLine();
            if (stk1.IsEmpty())
                Console.WriteLine("Stack stk1 is empty");
            Console.WriteLine("Again push symbol A-J in stack stk1");
            for (int i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));
            Console.WriteLine("Pop from stk1 and push in stk2");
            while (!stk1.IsEmpty())
                stk2.Push(stk1.Pop());
            Console.WriteLine("Content stk2");
            while (!stk2.IsEmpty())
                Console.Write(stk2.Pop());
            Console.WriteLine();
            Console.WriteLine("Push 5 symbol in stk3");
            for (int i = 0; i < 5; i++)
                stk3.Push((char)('A' + i));
            Console.WriteLine("Capacity stack stk3:" + stk3.Capacity());
            Console.WriteLine("Count object in stk3: " + stk3.GetNum());
        }
    }
}
