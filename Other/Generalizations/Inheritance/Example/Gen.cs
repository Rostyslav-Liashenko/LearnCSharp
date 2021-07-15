namespace LearnGeneralization
{
    public class Gen<T>
    {
        private T ob;

        public Gen(T o)
        {
            ob = o;
        }

        public T GetOb()
        {
            return ob;
        }
    }
}
