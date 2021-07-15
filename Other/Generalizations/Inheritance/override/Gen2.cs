using System;

namespace LearnGeneralization
{
    public class Gen2<T> : Gen<T>
    {
        public Gen2(T ob) : base(ob)
        {}

        public override T GetOb()
        {
            Console.WriteLine("Method GetOb() from Gen2");
            return ob;
        }
        
    }
}
