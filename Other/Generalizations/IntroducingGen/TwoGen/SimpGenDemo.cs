using System;

namespace LearnGeneralization
{
    class SimpGen
    {
        static void Main()
        {
            TwoGen<int, string> tgObj = new TwoGen<int, string>(119, "Alpha betta gamma");
            tgObj.ShowTypes();
            int v = tgObj.getob1();
            Console.WriteLine("Value: " + v);
            string str = tgObj.getob2();
            Console.WriteLine("Value: " + str);
        }
    }
}
