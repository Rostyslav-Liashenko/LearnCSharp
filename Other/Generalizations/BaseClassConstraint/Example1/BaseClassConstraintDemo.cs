using System;

namespace LearnGeneralization
{
    class BaseClassConstraintDemo
    {
        static void Main()
        {
            A a = new A();
            B b = new B();
            C c = new C();

            Test<A> t1 = new Test<A>(a);
            t1.SayHello();
            Test<B> t2 = new Test<B>(b);
            t2.SayHello();
            //Test<C> t3 = new Test<C>(c); 
            //t3.SayHello();
        }
    }
}
