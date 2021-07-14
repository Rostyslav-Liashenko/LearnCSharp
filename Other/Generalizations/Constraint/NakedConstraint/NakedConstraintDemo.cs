namespace LearnGeneralization
{
    class NakedConstraintDemo
    {
        static void Main()
        {
            Gen<A, B> x = new Gen<A, B>();
            Gen<A, A> z = new Gen<A, A>();
            Gen<B, B> d = new Gen<B, B>();
            //Gen<B, A> y = new Gen<B, A>(); Error
        }
    }
}
