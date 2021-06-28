using System;

namespace LearnDelegate
{
    class MultiCastDemoTwo
    {

        delegate void OpTwo(ref int num);
        
        static void AddTwo(ref int a)
        {
            a += 2;
        }

        static void SubTwo(ref int a)
        {
            a -= 2;
        }

        static void MultiplyTwo(ref int a)
        {
            a *= 2;
        }
        
        static void Main()
        {
            OpTwo myOp = AddTwo;
            myOp += MultiplyTwo;
            myOp += AddTwo;
            int num = 10;
            myOp(ref num);
            Console.WriteLine("num = " + num);
            myOp -= MultiplyTwo;
            num = 10;
            myOp(ref num);
            Console.WriteLine("num = " + num);
        }
        
    }
}
