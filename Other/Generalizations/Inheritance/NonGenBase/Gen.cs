namespace LearnGeneralization
{
    public class Gen<T> : NonGen
    {
        private T ob;

        public Gen(T o, int i) : base(i)
        {
            ob = o;
        }

        public T GetOb()
        {
            return ob;
        }
        
    }
}
