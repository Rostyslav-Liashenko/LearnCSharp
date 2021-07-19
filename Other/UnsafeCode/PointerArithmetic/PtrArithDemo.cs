using System;

namespace LearnPointer
{
    class PtrArithDemo
    {
        static unsafe void Main()
        {
            int i;
            double d;
            int* ip = &i;
            double* fp = &d;
            Console.WriteLine("int double\n");
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("{0} {1}", (uint) ip, (uint) fp);
                ip++;
                fp++;
            }
                
        }
    }
}
