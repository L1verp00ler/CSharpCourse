using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    class Program
    {
        delegate int Operation(int x, int y); // Объявляем делегат

        static void Main(string[] args)
        {
            // Присваивание адреса метода через конструктор
            Operation del = new Operation(Add);
            int result = del.Invoke(4, 5);
            Console.WriteLine(result);

            del = Multiply; // Теперь делегат указывает на метод Multiply
            result = del.Invoke(4, 5);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
