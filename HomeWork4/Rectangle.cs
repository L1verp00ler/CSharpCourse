
namespace HomeWork4
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override string GetName { get; } = "Прямоугольник";

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
