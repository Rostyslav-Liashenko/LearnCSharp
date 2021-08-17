using System;
using System.Collections.Generic;

namespace LearnCollections
{
    class StackDemo
    {
        static void Main()
        {
            Stack<string> st = new Stack<string>();
            st.Push("First");
            st.Push("Second");
            st.Push("Third");
            st.Push("Fourth");
            st.Push("Fifth");
            while (st.Count > 0)
            {
                string str = st.Pop();
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}
