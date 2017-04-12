using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Car : Detail
    {
        public Detail[] detailsArray;

        public override int Weight { get; set; }
        public override string Name { get; set; } = "Машина неизвестной модели";

        public uint NumberOfWheels { get; set; }
        public uint NumberOfDoors { get; set; }

        public string Model { get; private set; }

        public Car(uint numberOfWheels, uint numberOfDoors, string model)
        {
            NumberOfWheels = numberOfWheels;
            NumberOfDoors = numberOfDoors;
            Model = model;

            // Инициализация массива для хранения деталей автомобиля
            Detail[] detailsArray = new Detail[numberOfWheels + numberOfDoors + 1];

            // Добавляем в массив колеса
            for (uint i = 1; i <= numberOfWheels; i++)
            {
                detailsArray[i - 1] = new Wheel(i, this); // Почему сюда передаем ссылку на объект? ведь он еще не создан, или создан???
            }

            Console.WriteLine(detailsArray.GetType());

            // Добавляем в массив двери
            for (uint i = 1, j = numberOfWheels; i <= numberOfDoors; i++)
            {
                detailsArray[i + j - 1] = new Door(i, this);
            }

            // Добавляем в массив раму
            detailsArray[detailsArray.Length - 1] = new Body(this);
            
            for (int i = 0; i < detailsArray.Length; i++)
            {
                Console.WriteLine(detailsArray[i]);
            }

            this.detailsArray = detailsArray;

            /*
            foreach (var detail in detailsArray)
            {
                Console.WriteLine(detail.GetType());

                /*
                var perem1 = detail as IRotatable;
                Console.WriteLine(perem1);
                if (perem1 != null)
                {
                    Console.WriteLine(perem1.GetType());
                }
                else
                {
                    Console.WriteLine("Объекта не существует!");
                }
                
                //
                if (detail is IRotatable)
                {
                    //detail.Move();
                    Console.WriteLine(detail.Name);
                    //Console.WriteLine(detail.Name + detail.Number); // Почему такое не работает???
                    //Console.WriteLine((Wheel)detail.);
                }
                //
            }
            */
        }
    }
}
