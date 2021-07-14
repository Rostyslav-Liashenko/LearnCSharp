namespace LearnGeneralization
{
    public class Test<T> where T : A
    {
        private T obj;

        public Test(T o)
        {
            obj = o;
        }

        public void SayHello()
        {
            obj.Hello();
        }
    }
}
