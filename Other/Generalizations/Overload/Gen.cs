namespace LearnGeneralization
{
    public class Gen<T, V>
    {
        private T ob1;
        private V ob2;
        
        public void Set(T o)
        {
            ob1 = o;
        }
        
        public void Set(V o)
        {
            ob2 = o;
        }
    }
}
