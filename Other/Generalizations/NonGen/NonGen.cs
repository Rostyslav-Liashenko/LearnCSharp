using System;

namespace LearnGeneralization
{
    public class NonGen
    {
        private object ob;

        public NonGen(object o)
        {
            ob = o;
        }

        public object GetOb()
        {
            return ob;
        }

        public void ShowType()
        {
            Console.WriteLine("it is " + ob.GetType());
        }
    }
}
