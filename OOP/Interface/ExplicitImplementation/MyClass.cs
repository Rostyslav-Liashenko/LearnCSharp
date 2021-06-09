namespace LearnInterfaceProperties
{
    public class MyClass : IMyIF_A, IMyIF_B
    {
        int IMyIF_A.Meth(int x)
        {
            return x + x;
        }

        int IMyIF_B.Meth(int x)
        {
            return x * x;
        }

        public int MethA(int x)
        {
            IMyIF_A a_ob = this;
            return a_ob.Meth(x);
        }

        public int MethB(int x)
        {
            IMyIF_B b_ob = this;
            return b_ob.Meth(x);
        }
        
        
    }
}
