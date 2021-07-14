namespace LearnGeneralization
{
    public class Test<T> where T : struct
    {
        private T obj;

        public Test(T x)
        {
            obj = x;
        }
    }
}
