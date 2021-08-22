using System;
using System.Linq;

namespace LearnFeatures
{
    static class TupleDemo
    {

        private static (int, int) GetValues()
        {
            (int, int) result = (1, 3);
            return result;
        }

        private static (int sum, int count) GetSumAndCount(int[] numbers)
        {
            var result = (sum: numbers.Sum(), count: numbers.Length);
            return result;
        }

        private static void PrintTuple((int x, int y) someTuple)
        {
            Console.WriteLine("In method Tuple.Item1 = {0}, Tuple.Item2 = {1}", someTuple.x, someTuple.y);
        }
        
        static void Main()
        {
            var tuple = (5, 10);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            (string, int, double) person = ("Tom", 25, 81.23);
            Console.WriteLine("{0}: {1}, {2}", person.Item1, person.Item2, person.Item3);
            var tuple2 = (count:5, sum:10); // naming field of tuple
            Console.WriteLine("Count = " + tuple2.count);
            Console.WriteLine("Sum = " + tuple2.sum);
            (int x, int y) someTuple = (5, 10);
            Console.WriteLine("X = " + someTuple.x);
            Console.WriteLine("Y = " + someTuple.y);
            (int num1, int num2) someRetTuple = GetValues();
            Console.WriteLine("SomeRetTuple.num1 = " + someRetTuple.num1);
            Console.WriteLine("SomeRetTuple.num2 = " + someRetTuple.num2);
            (int num1, int num2) someRetTuple2 = GetSumAndCount(new int[] {1, 2, 3, 4,});
            Console.WriteLine("SomeRetTuple2.num1 = " + someRetTuple2.num1);
            Console.WriteLine("SomeRetTuple2.num2 = " + someRetTuple2.num2);
            PrintTuple((12, 56));
        }
    }
}
