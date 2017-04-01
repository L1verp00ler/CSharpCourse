using System;

namespace HomeWork4
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public override string GetName { get; } = "Круг";

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
