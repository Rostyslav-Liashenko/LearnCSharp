using System;

namespace ConsoleApp3
{
    public class MyClass
    {
        public void ShowArgs(string msg, params int[] nums)
        {
            Console.WriteLine(msg);
            foreach(int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        
    }
}
