using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_TestTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = 0;
            
            Console.Write("Введите натуральное число, большее 0: ");

            try
            {
                number = UInt32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод!");
                Console.Read();
                return;
            }

            if (number == 0)
            {
                Console.WriteLine("Число должно быть больше нуля!");
                Console.Read();
                return;
            }

            uint factorial = Factorial(number);
            uint factorialMultiply = FactorialMultiply(number);

            Console.WriteLine("Факториал " + number + " равен " + factorial + ".");
            Console.WriteLine("Произведение факториалов чисел от 1 до " + number + " равно " + factorialMultiply + ".");
            Console.Read();
        }

        // Произведение факториалов чисел от 1 до n
        static uint FactorialMultiply(uint number)
        {
            uint result = 1;
            for (uint i = 1; i < number + 1; i++)
            {
                result *= Factorial(i);
            }
            return result;
        }

        // Вычисление факториала числа
        static uint Factorial(uint number)
        {
            uint result = 1;
            for (uint i = 1; i < number + 1; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
