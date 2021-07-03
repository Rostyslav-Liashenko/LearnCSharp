using System;

namespace LearnEvent
{
    static class LambdaEventDemo2
    { 
        public static void Main()
        {
            NumOp numOp = new NumOp();
            numOp.OperationWithNum += (a, b) =>
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            };
            numOp.OperationWithNum += (a, b) =>
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            };
            numOp.OperationWithNum += (a, b) =>
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            };
            numOp.OnOperation(5,2);
        }
    }
}
