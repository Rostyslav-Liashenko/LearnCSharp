using System;

namespace LearnFeatures
{
    static class ReferenceVariable
    {

        static ref int Find(int target, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == target)
                    return ref numbers[i];
            throw new IndexOutOfRangeException();
        }

        static ref int GetMax(ref int num1, ref int num2)
        {
            //ref int max = num1 > num2 ? ref num1 : ref num2;
            if (num1 > num2)
                return ref num1;
            else
                return ref num2;
        }
        
        static void Main()
        {
            Console.WriteLine("First example");
            int x = 5;
            ref int xRef = ref x;
            Console.WriteLine(x); // 5
            xRef = 125;
            Console.WriteLine(x); // 125
            xRef = 625;
            Console.WriteLine(x); // 625
            Console.WriteLine("Second example");
            int[] numbers = {1, 2, 3, 4, 5, 6, 7};
            ref int numberRef = ref Find(4, numbers);
            numberRef = 9;
            Console.WriteLine(numbers[3]); // 9
            Console.WriteLine("Third example");
            int a = 5;
            int b = 8;
            ref int p = ref GetMax(ref a, ref b);
            Console.WriteLine(p);
        }
    }
