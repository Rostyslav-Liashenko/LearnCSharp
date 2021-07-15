using System;

namespace LearnGeneralization
{
    public delegate bool SomeOp<in T>(T obj);
    public delegate T AnotherOp<out T, V>(V obj);
    
    public class GenDelegateVarianceDemo
    {
        static bool IsEven(Alpha obj)
        {
            return obj.Val % 2 == 0;
        }

        static Beta ChangeIt(Alpha obj)
        {
            return new Beta(obj.Val + 2);
        }

        static void Main()
        {
            Alpha objA = new Alpha(4);
            Beta objB = new Beta(9);
            SomeOp<Alpha> checkIt = IsEven;
            SomeOp<Beta> checkIt2;
            checkIt2 = checkIt;
            Console.WriteLine(checkIt2(objB));
            
            AnotherOp<Beta, Alpha> modifyIt = ChangeIt;
            AnotherOp<Alpha, Alpha> modifyIt2;
            modifyIt2 = modifyIt;
            objA = modifyIt2(objA);
            Console.WriteLine(objA.Val);
        }
    }
}