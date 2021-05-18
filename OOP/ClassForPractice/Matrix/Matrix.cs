using System;

namespace ConsoleApp4
{
    public class Matrix
    {
        private double[,] matrix;
        private int column;
        private int row;

        public Matrix(int row, int column)
        {
            matrix = new double[row, column];
            this.column = column;
            this.row = row;
        }

        public void RandomFill()
        {
            Random random = new Random();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    matrix[i, j] = random.Next(10);
        }

        public void Multiple(double n)
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    matrix[i, j] *= n;
        }

        public Matrix Add(Matrix ob)
        {
            Matrix tmp = new Matrix(row, column);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    tmp.matrix[i, j] = matrix[i, j] + ob.matrix[i, j];
            return tmp;
        }

        public Matrix Multiple(Matrix ob)
        {
            // TODO Create Multiple for two matrix
            return this;
        }
        
        public void Show()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
