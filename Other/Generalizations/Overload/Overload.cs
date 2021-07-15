using System;

namespace LearnGeneralization
{
    public class OverloadDemo
    {
        static void Main()
        {
            Gen<int, double> ok = new Gen<int, double>();
            Gen<int, int> notOk = new Gen<int, int>();
            ok.Set(10);
            ok.Set(5.43);
            //notOk.Set(10); Error
        }
    }
}
