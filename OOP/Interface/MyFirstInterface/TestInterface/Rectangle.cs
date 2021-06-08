namespace TestDifferentFeatures.TestInterface
{
    public class Rectangle : IFigure
    {
        protected double width;
        private double height;
        
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
        
        public Rectangle() : this(0,0)
        {}

        public virtual double GetArea()
        {
            return width * height;
        }

        public virtual double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
}
