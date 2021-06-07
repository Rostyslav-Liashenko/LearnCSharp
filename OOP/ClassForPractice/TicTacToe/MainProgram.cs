using System;

namespace ConsoleApp5.TicTacToe
{
    class MainProgram
    {
        private const int MaxRow = 3;
        private const int MaxColumn = 3;
        
        private static bool OneStep(Player p1, Area area)
        {
            Console.WriteLine("Player " + p1.Id  + " input the row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Player" + p1.Id +  " input the col: ");
            int col = Convert.ToInt32(Console.ReadLine());
            if (!p1.SetStep(row - 1 , col - 1, MaxRow, MaxColumn, area))
                return false;
            area.SetCell(p1);
            Console.Clear();
            area.Show();
            return true;
        }
        
        static int Main()
        {
            Area area = new Area(MaxRow, MaxColumn);
            Player p1 = new Player(1, 'X');
            Player p2 = new Player(2, 'O');
            while (!area.Checker(p1) && !area.Checker(p2))
            {
                while (!OneStep(p1, area)) ;
                while (!OneStep(p2, area)) ;
                
            }
            // TODO проверку на законченость игры
            return 0;
        }
    }
}
