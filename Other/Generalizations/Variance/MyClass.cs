namespace LearnGeneralization
{
    public class MyClass<T> : IMyCoVarGenIF<T>
    {
        private T obj;

        public MyClass(T v)
        {
            obj = v;
        }

        public T GetObject()
        {
            return obj;
        }
    }
}