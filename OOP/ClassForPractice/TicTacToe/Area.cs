using System;

namespace GameTicTacToe
{
    public class Area
    {
        private char[,] area; // matrix for present area for game
        private int rows; // count rows in area
        private int cols; // count column

        public Area(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            area = new char[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                 area[i, j] = 'n';
        }

        public void SetCell(Player p)
        {
            area[p.Row,p.Col] = p.Symbol;
        }

        public bool CheckFill(int row, int col)
        {
            return area[row, col] == 'X' || area[row,  col] == 'O';
        }
        private bool FinishCheck(ref int number)
        {
            if (number == rows)
                return true;
            else
            {
                number = 0;
                return false;
            }
        }
        public bool Checker(Player p1)
        {
            int scoore = 0;
            
            for (int i = 0; i < rows; i++) // col
            {
                for (int j = 0; j < cols; j++)
                {
                    if (area[i, j] == p1.Symbol)
                        scoore++;
                }

                if (FinishCheck(ref scoore))
                    return true;
            }

            for (int i = 0; i < rows; i++) // row
            {
                for (int j = 0; j < cols; j++)
                {
                    if (area[j, i] == p1.Symbol)
                        scoore++;
                }

                if (FinishCheck(ref scoore))
                    return true;
            }

            for (int i = 0; i < rows; i++) // main diagonal
            {
                if (area[i, i] == p1.Symbol)
                    scoore++;
            }

            if (FinishCheck(ref scoore))
                return true;
            
            for (int i = 0; i < rows; i++) // slave diagonal
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i + j == rows - 1 && area[i, j] == p1.Symbol)
                        scoore++;
                    
                }
            }
            if (FinishCheck(ref scoore))
                return true;   
            return false;
        }
        
        public void Show()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(area[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
