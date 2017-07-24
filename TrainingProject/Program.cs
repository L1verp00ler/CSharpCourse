using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    class Program
    {
        delegate void GetMessage(); // Объявляем делегат

        static void Main(string[] args)
        {
            GetMessage del; // Создаем переменную делегата

            if (DateTime.Now.Hour < 12)
            {
                del = GoodMorning; // Присваиваем переменной адрес метода
            }
            else
            {
                del = GoodEvening;
            }

            del.Invoke();
            Console.ReadLine();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning!");
        }

        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening!");
        }

    }
}
