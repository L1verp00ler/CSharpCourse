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
            Console.WriteLine(">>>>> Приложение \"Автомобиль\" <<<<<\r\n");

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
                        foreach (Detail detail in car.detailsArray)
                        {
                            // Можно переписать по-другому (см. ниже)
                            IRotatable detail1 = detail as IRotatable;
                            if (detail1 != null)
                            {
                                detail1.Move();
                            }

                            //(detail as IRotatable)?.Move(); - Это "синтаксический сахар"???

                            /*
                            if (detail as IRotatable != null)
                            {
                                ((IRotatable)detail).Move(); // Не понятно, почему работает именно так
                                // типа, если он объект класса реализует такой интерфейс(наследуется), то он является таким типом???
                            }
                            */
                        }
                        break;
                    case "O":
                        Console.Write("Введите номер двери или 0 для рамы: ");
                        uint doorNumber = UInt32.Parse(Console.ReadLine());

                        if (doorNumber == 0)
                        {
                            foreach (Detail detail in car.detailsArray)
                            {
                                // Можно переписать по-другому (см. ниже)
                                Body detail1 = detail as Body;
                                if (detail1 != null)
                                {
                                    detail1.Open();
                                }
                            }
                        }
                        else
                        {
                            bool isDoorExistInCar = false;

                            foreach (Detail detail in car.detailsArray)
                            {
                                // Можно переписать по-другому (см. ниже)
                                //
                                Door door = detail as Door;
                                if (door != null && door.Number == doorNumber)
                                {
                                    door.Open();
                                    isDoorExistInCar = true;
                                    break;
                                }
                                //

                                // Это "синтаксический сахар" для операции "... is ..."??? (было предложено студией)
                                /*
                                if (detail is Door door)
                                {
                                    door.Open();
                                }
                                */
                            }

                            if (!isDoorExistInCar)
                            {
                                Console.WriteLine("Двери с таким номером не существует!");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Выбрано некорректное действие!");
                        break;
                }
                Console.Write("\r\nДля повтора введите 'r', для выхода - любой символ: ");
            }
            while (Console.ReadLine() == "r");
        }
    }
}
