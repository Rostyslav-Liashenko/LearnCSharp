namespace LearnGeneralization
{
    public class ByTwos<T> : ISeries<T>
    {
        public delegate T IncByTwo(T v);
        private T start;
        private T val;
        private IncByTwo incr;

        public ByTwos(IncByTwo incrMeth)
        {
            start = default(T);
            val = default(T);
            incr = incrMeth;
        }

        public T GetNext()
        {
            val = incr(val);
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(T v)
        {
            start = v;
            val = start;
        }
        
        
    }
}
