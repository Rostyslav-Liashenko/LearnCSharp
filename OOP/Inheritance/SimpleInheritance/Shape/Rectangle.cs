namespace ConsoleApp6.Shape
{
    public class Rectangle : TwoDShape
    {
        public bool IsSquare()
        {
            return Width == Height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}
