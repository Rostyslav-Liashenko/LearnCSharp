using System;

namespace ConsoleApp4
{
    class CountDemo
    {
    
        static void Main()
        {
            CountInst ob;
            for (int i = 0; i < 10; i++)
            {
                ob = new CountInst();
                Console.WriteLine("Current number object:" + CountInst.GetCount()); 
            }
        }
    }
}
