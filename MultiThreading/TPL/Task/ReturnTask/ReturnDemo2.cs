using System;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTPL
{
    class ReturnDemo2
    {

        private static int SumArray(object ar)
        {
            int[] localArray = (int[]) ar;
            return localArray.Sum();
        }

        private static int ProductArray(object ar)
        {
            int[] localArray = (int[]) ar;
            int product = 1;
            foreach (var el in localArray)
                product *= el;

            return product;
        }

        private static void ShowArray<T>(T[] array)
        {
            foreach (var el in array)
                Console.Write(el + " ");
            Console.WriteLine();
        }
        
        static void Main()
        {
            Random rand = new Random();
            Console.WriteLine("input the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1, 10);
            Console.WriteLine("Your array: ");
            ShowArray(array);
            Task<int> sumTask = Task<int>.Factory.StartNew(SumArray, array);
            Task<int> productTask = Task<int>.Factory.StartNew(ProductArray, array);
            sumTask.Wait();
            Console.WriteLine("Sum = {0}", sumTask.Result);
            productTask.Wait();
            Console.WriteLine("Product = {0}", productTask.Result);
        }
    }
}
