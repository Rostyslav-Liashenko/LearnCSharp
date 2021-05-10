using System;

namespace ConsoleApp3
{
    public class Stack
    {
        private char[] stck;
        private int _tos;

        public Stack(int size)
        {
            stck = new char[size];
            _tos = 0;
        }

        public void Push(char ch)
        {
            if (IsFull())
            {
                Console.WriteLine("stack is full");
                return;
            }

            stck[_tos] = ch;
            _tos++;
        }

        public char Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
                return (char) 0;
            }

            _tos--;
            return stck[_tos];
        }

        public bool IsFull()
        {
            return _tos == stck.Length;
        }

        public bool IsEmpty()
        {
            return _tos == 0;
        }

        public int Capacity()
        {
            return stck.Length;
        }

        public int GetNum()
        {
            return _tos;
        }
    }
}
