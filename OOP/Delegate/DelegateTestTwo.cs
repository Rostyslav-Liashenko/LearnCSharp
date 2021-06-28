using System;

namespace LearnDelegate
{
    class DelegateTestTwo
    {
        delegate int NumOp(int a, int b);

        static int AddTwoNum(int a, int b)
        {
            return a + b;
        }

        static int SubTwoNum(int a, int b)
        {
            return a - b;
        }

        static int MultiplyTwoNum(int a, int b)
        {
            return a * b;
        }
        
        static void Main()
        {
            NumOp myNumOp = AddTwoNum;
            Console.WriteLine("5 + 2 = " + myNumOp(5,2));
            myNumOp = SubTwoNum;
            Console.WriteLine("5 - 2 = " + myNumOp(5,2));
            myNumOp = MultiplyTwoNum;
            Console.WriteLine("5 * 2 = " + myNumOp(5,2));
        }
    }
}
