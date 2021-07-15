namespace LearnGeneralization
{
    public class Gen2<T, V> : Gen<T>
    {
        private V ob2;
        public Gen2(T o, V o2) : base(o)
        {
            ob2 = o2;
        }

        public V GetObj2()
        {
            return ob2;
        }
        
        
    }
}
