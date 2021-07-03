using System;

namespace GameTicTacToe
{
    public class Player
    {
        public int Id { get; private set; }
        public char Symbol { get; private set; }
        public int Row { get; private set; } 
        public int Col { get; private set; }

        public bool SetStep(int row, int col, int maxRow, int maxCol, Area area)
        {
            if (area.CheckFill(row, col))
            {
                Console.WriteLine("\nThis cell is not empty\n");
                area.Show();
                return false;
            }
            
            if ((row >= 0 && row < maxRow) && (col >= 0 && col < maxCol))
            {
                Row = row;
                Col = col;
                return true;
            }
            else 
                return false;
        }
        
        public Player(int id, char symbol)
        {
            Id = id;
            Symbol = symbol;
        }
    }
}
