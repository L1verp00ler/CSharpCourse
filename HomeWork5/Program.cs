using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание автомобиля...");

            Console.Write("Введите модель автомобиля: ");
            string carModel = Console.ReadLine();

            Console.Write("Введите количество колес: ");
            uint numberOfWheels = UInt32.Parse(Console.ReadLine());

            Console.Write("Введите количество дверей: ");
            uint numberOfDoors = UInt32.Parse(Console.ReadLine());

            Car car = new Car(numberOfWheels, numberOfDoors, carModel);

            do
            {
                Console.Write("\nВыберите действие: M - Move, O - Open door: ");
                switch (Console.ReadLine())
                {
                    case "M":
                        Console.WriteLine("Move");
                        break;
                    case "O":
                        Console.Write("Введите номер двери или 0 для рамы: ");
                        uint numberOfDoor = UInt32.Parse(Console.ReadLine());

                        break;
                    default:
                        Console.WriteLine("Введено неверное действие!");
                        break;
                }
                Console.Write("Для повтора введите 'r', для выхода - любой символ : ");
            }
            while (Console.ReadLine() == "r");

            //Console.WriteLine(car.Name);
            //Console.Read();
        }
    }
}
