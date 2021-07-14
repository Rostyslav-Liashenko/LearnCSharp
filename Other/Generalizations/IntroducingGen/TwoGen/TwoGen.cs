using System;

namespace LearnGeneralization
{
    public class TwoGen<T, V>
    {
        private T ob1;
        private V ob2;
        
        public TwoGen(T o1, V o2)
        {
            ob1 = o1;
            ob2 = o2;
        }

        public void ShowTypes()
        {
            Console.WriteLine("T it is =" + typeof(T));
            Console.WriteLine("V it is = " + typeof(V));
        }

        public T getob1()
        {
            return ob1;
        }

        public V getob2()
        {
            return ob2;
        }
    }
}
