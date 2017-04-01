using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Нужно добавить проверку на ввод нулевых и отрицательных значений!!! (в set;)
            Rectangle rect1 = new Rectangle(5, 9);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", rect1.GetName, rect1.GetPerimeter(), rect1.GetArea());
            Rectangle rect2 = new Rectangle(10.5, 2.0);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", rect2.GetName, rect2.GetPerimeter(), rect2.GetArea());
            Rectangle rect3 = new Rectangle(5.500000000005, 9.05055055505);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", rect3.GetName, rect3.GetPerimeter(), rect3.GetArea());
            Console.WriteLine();

            Triangle triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", triangle1.GetName, triangle1.GetPerimeter(), triangle1.GetArea());
            Triangle triangle2 = new Triangle(10, 6, 8);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", triangle2.GetName, triangle2.GetPerimeter(), triangle2.GetArea());
            Triangle triangle3 = new Triangle(20, 10, 12);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", triangle3.GetName, triangle3.GetPerimeter(), triangle3.GetArea());
            Console.WriteLine();

            Circle circle1 = new Circle(5.5);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", circle1.GetName, circle1.GetPerimeter(), circle1.GetArea());
            Circle circle2 = new Circle(7.9);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", circle2.GetName, circle2.GetPerimeter(), circle2.GetArea());
            Circle circle3 = new Circle(30);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", circle3.GetName, circle3.GetPerimeter(), circle3.GetArea());
            Console.WriteLine();

            Sector sector1 = new Sector(5, 3);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", sector1.GetName, sector1.GetPerimeter(), sector1.GetArea());
            Sector sector2 = new Sector(10, 5.5);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", sector2.GetName, sector2.GetPerimeter(), sector2.GetArea());
            Sector sector3 = new Sector(17.9, 8.8);
            Console.WriteLine("Фигура - {0}. Его периметр составляет {1}, а площадь - {2}.", sector3.GetName, sector3.GetPerimeter(), sector3.GetArea());
            Console.WriteLine();

            Console.Read();
        }
    }
}
