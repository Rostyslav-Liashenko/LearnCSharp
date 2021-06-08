namespace TestDifferentFeatures.TestInterface
{
    public class Square : Rectangle
    {
        public Square() : base(0, 0)
        {}
        
        public Square(double x) : base(x,x)
        {}
        
        public override double GetArea()
        {
            return width * width;
        }

        public override double GetPerimeter()
        {
            return 4 * width;
        }
    }
}
