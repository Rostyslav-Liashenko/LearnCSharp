using System;

namespace LearnGeneralization
{
    class MyStackDemo
    {
        static void Main()
        {
            Console.WriteLine("Stack int");
            MyStack<int> intStack = new MyStack<int>(25);
            for (int i = 0; i < 26; i++)
                intStack.Push(i + 1);
            try
            {
                for (int i = 0; i < 26; i++)
                {
                    int tmp = intStack.Pop();
                    Console.Write(tmp + " ");
                }
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine();
                Console.WriteLine(e);
            }
            Console.WriteLine("Stack char");
            MyStack<char> charStack = new MyStack<char>(25);
            for (int i = 0; i < 26; i++)
                charStack.Push((char)('A' + i));
            try
            {
                for (int i = 0; i < 26; i++)
                {
                    char tmp = charStack.Pop();
                    Console.Write(tmp + " ");
                }
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine();
                Console.WriteLine(e);
            }
        }
    }
}
