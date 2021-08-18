using System.Collections.Generic;

namespace LearnCollections
{
    public class MyClass<T>
    {
        private T[] array;

        public MyClass(T[] a)
        {
            array = a;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T obj in array)
            {
                yield return obj;
            }
        }
    }
}
