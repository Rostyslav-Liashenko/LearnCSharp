using System;

namespace LearnGeneralization
{
    public class MyStack<T>
    {
        private T[] stack;
        private int tos;
        private int size;

        public MyStack(int size)
        {
            this.size = size;
            stack = new T[size];
            tos = 0;
        }

        public void Push(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            stack[tos] = item;
            tos++;
        }

        public T Pop()
        {
            IsEmpty();
            return stack[--tos];
        }

        public bool IsFull()
        {
            return tos == size;
        }

        public void IsEmpty()
        {
            if (tos == 0)
                throw new StackEmptyException("Stack is empty");
        }

    }
}
