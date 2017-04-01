
namespace HomeWork4
{
    class Sector : Figure
    {
        public double ArcLength { get; set; }
        public double Radius { get; set; }

        public override string GetName { get; } = "Сектор";

        public Sector(double arcLength, double radius)
        {
            this.ArcLength = arcLength;
            this.Radius = radius;
        }

        public override double GetPerimeter()
        {
            return ArcLength + 2 * Radius;
        }

        public override double GetArea()
        {
            return ArcLength * Radius / 2;
        }
    }
}
