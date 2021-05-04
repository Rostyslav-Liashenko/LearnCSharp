namespace ConsoleApp2
{
    public class Rect
    {
        private int width;
        private int height;

        public Rect(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return width * height;
        }
    }
}
