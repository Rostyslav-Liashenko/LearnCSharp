using System;

namespace LearnPartical
{
    public partial class XY
    {
        public int X { get; set; }
        public int Y { get; set; }

        partial void Show()
        {
            Console.WriteLine("{0}, {1}", X, Y);
        }

        public void ShowXY()
        {
            Show();
        }
    }
}
