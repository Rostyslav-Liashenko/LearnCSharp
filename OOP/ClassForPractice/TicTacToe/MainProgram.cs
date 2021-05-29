using System;

namespace ConsoleApp5.TicTacToe
{
    class MainProgram
    {
        static int Main()
        {
            const int maxRow = 3;
            const int maxColumn = 3;
            Area area = new Area(maxRow, maxColumn);
            Player p1 = new Player(1, 'X');
            Player p2 = new Player(2, 'O');
            while (!area.Checker(p1) && !area.Checker(p2))
            {
                Console.WriteLine("Player 1 input the row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Player 1 input the col: ");
                int col = Convert.ToInt32(Console.ReadLine());
                
                p1.SetStep(row, col, maxRow, maxColumn);
                area.SetCell(p1);
                area.Show();
                
                Console.WriteLine("Player 2 input the row: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Player 2 input the col: ");
                col = Convert.ToInt32(Console.ReadLine());
                
                p2.SetStep(row, col, maxRow, maxColumn);
                area.SetCell(p2);
                area.Show();
            }
            // TODO сделать чтобы не можно було ставить на уже заняте место
            // TODO проверку на законченость игры
            // TODO сделать проверку выход за край
            // TODO окоротить главную функцию
            return 0;
        }
    }
}
