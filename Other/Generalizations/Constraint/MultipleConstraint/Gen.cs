namespace LearnGeneralization
{
    public class Gen<T, V> where T : class
                            where V : struct
    {
        private T ob1;
        private V ob2;

        public Gen(T t, V v)
        {
            ob1 = t;
            ob2 = v;
        }
    }
}
