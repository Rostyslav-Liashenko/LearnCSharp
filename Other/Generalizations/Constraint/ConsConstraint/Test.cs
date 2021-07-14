namespace LearnGeneralization
{
    public class Test<T> where T : new ()
    {
        private T obj;

        public Test()
        {
            obj = new T();
        }
    }
}
