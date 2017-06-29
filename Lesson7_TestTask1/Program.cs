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
            if (number == 1)
            {
                return 1;
            }

            uint result = 1;
            uint lastElem = 1;
            //uint tekElem;

            for (uint i = 1; i < number + 1; i++)
            {
                // tekElem = lastElem * i;
                // result = result * tekElem;
                // lastElem = tekElem;
                
                // Запись ниже - это сокращенная запись кода в комментах выше (так менее понятно, но зато сипользуем меньше переменных)
                lastElem *= i; // На самом деле тут считается текущий элемент, он будет предыдущим уже на следующем шаге цикла!
                result *= lastElem; // lastElem = lastElem * i, result = result * lastElem, ===> result = result * lastElem * i;
            }

            return result;
        }

        // Вычисление факториала числа
        static uint Factorial(uint number)
        {
            if (number == 1)
            {
                return 1;
            }

            uint result = 1;

            for (uint i = 1; i < number + 1; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
