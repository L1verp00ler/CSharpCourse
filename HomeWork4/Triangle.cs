using System;

namespace HomeWork4
{
    class Triangle : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public override string GetName { get; } = "Треугольник";

        public Triangle(float side1, float side2, float side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public override double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override double GetArea()
        {
            double semiperimeter = this.GetPerimeter() / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
        }
    }
}
