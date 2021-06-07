namespace ConsoleApp6.Shape
{
    public class Rectangle : TwoDShape
    {
        public Rectangle(double w, double h) : base(w, h, "rectangle")
        {}

        public Rectangle(double x) : base(x, "square rectangle")
        {}

        public Rectangle(Rectangle ob) : base(ob)
        {}
        
        public bool IsSquare()
        {
            return Width == Height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
