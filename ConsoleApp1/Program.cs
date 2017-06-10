using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine2D.Draw(
                new[]
                    {
                        new Star(5, 5),
                        new Star(20, 8, ConsoleColor.Yellow),
                        new Star(10, 15, ConsoleColor.Red)
                    });

            Console.Read();
        }
    }

    abstract class Shape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public ConsoleColor Color { get; set; }

        protected Shape(int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
        }

        public abstract void Draw(int ticks);
    }

    static class Engine2D
    {
        public static void Draw(IEnumerable<Shape> shapes)
        {
            while (true)
            {
                Engine2D.Clear();
                foreach (var shape in shapes)
                {
                    shape.Draw();
                }

                Thread.Sleep(100);
                Ticks++;
            }
        }

        public static int Ticks { get; private set; }

        public 

        public static void SetPixel(int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write("+");
        }
    }

    class Star : Shape
    {
        public Star(int x, int y, ConsoleColor color = ConsoleColor.Blue)
            : base(x, y, color)
        {

        }

        public override void Draw(int ticks)
        {
            Engine2D.SetPixel(this.X - 1, this.Y);
            Engine2D.SetPixel(this.X + 1, this.Y);
            Engine2D.SetPixel(this.X, this.Y - 1);
            Engine2D.SetPixel(this.X, this.Y + 1);
            Engine2D.SetPixel(this.X, this.Y);
        }
    }

}
