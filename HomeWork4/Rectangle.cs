using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public override string Name { get; } = "Прямоугольник";

        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override float Perimeter()
        {
            return 2 * (Width + Height);
        }

        public override float Area()
        {
            return Width * Height;
        }
    }
}
