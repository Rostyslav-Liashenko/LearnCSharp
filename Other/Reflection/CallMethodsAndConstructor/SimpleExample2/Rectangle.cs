namespace LearnReflection
{
    public class Rectangle
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetPerimeter()
        {
            return 2 * (a + b);
        }

        public double GetArea()
        {
            return a * b;
        }
        
    }
}
