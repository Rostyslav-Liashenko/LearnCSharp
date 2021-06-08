using System;

namespace TestDifferentFeatures.TestInterface
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle()
        {
            radius = 0;
        }
        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
