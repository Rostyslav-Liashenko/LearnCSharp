using System;

namespace LearnGeneralization
{
    public delegate T SomeOp<T>(T v);
    
    class GenDelegateDemo
    {
        static int Sum(int v)
        {
            int result = 0;
            for (int i = v; i > 0; i--)
                result += i;
            return result;
        }

        static string Reflect(string str)
        {
            string result = " ";
            foreach (char ch in str)
                result = ch + result;
            return result;
        }
        
       static void Main()
       {
           SomeOp<int> intDel = Sum;
           Console.WriteLine(intDel(3));
           SomeOp<string> strDel = Reflect;
           Console.WriteLine(strDel("Hello"));
       }
    }
}
