namespace LearnException
{
    public class X
    {
        private int x;

        public X(int a)
        {
            x = a;
        }

        public int Add(X o)
        {
            return x + o.x;
        }
    }
}
