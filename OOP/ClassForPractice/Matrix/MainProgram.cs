using System;

namespace ConsoleApp4
{
    class MainProgram
    {
        static void Main()
        {
            Matrix matrix = new Matrix(3,3);
            matrix.RandomFill();
            matrix.Show();
            Console.Write("Input the n for multiple: ");
            int n = Convert.ToInt32(Console.ReadLine());
            matrix.Multiple(n);
            matrix.Show();
            Console.WriteLine("Add two matrix");
            Console.WriteLine("First matrix");
            matrix.Show();
            Console.WriteLine("Second matrix");
            Matrix matrix2 = new Matrix(3, 3);
            matrix2.RandomFill();
            matrix2.Show();
            Console.WriteLine("New matrix");
            Matrix matrix3 = matrix.Add(matrix2);
            matrix3.Show();
        }
    }
}
