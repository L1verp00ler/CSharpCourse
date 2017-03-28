using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[3]; // массив для хранения введенных пользователем чисел
                int number;

                Console.WriteLine("Введите 3 целых числа, которые больше нуля!");

                // Получаем от пользователя 3 числа
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Введите число №" + (i + 1));
                    if ((number = Int32.Parse(Console.ReadLine())) > 0)
                    {
                        numbers[i] = number; // если число верное, то добавляем его в массив
                    }
                    else
                    {
                        throw new Exception("Вводимые числа должны быть больше нуля!");
                    }
                }

                // Определяем наименьшее из 3-ёх введенных чисел и выводим его в консоль
                int min = Min(numbers);
                Console.WriteLine("Наименьшее число: " + min);

                Console.WriteLine("Последовательности Фиббоначчи:");

                // Выводим последовательности Фиббоначчи, последний элемент каждой из которых меньше соответствующего из 3-ёх чисел (3 последовательности)
                // 0 1 1 2 3 5 8 13 - пример для числа "14"
                for (int i = 0; i < numbers.Length; i++)
                {
                    FibbSequence(numbers[i]);
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " По ходу кто-то не умеет читать...");
            }

            Console.ReadLine();
        }

        // Вычисление наименьшего числа
        static int Min(int[] numbersArr)
        {
            int min;
            if (numbersArr[0] < numbersArr[1] && numbersArr[0] < numbersArr[2])
            {
                min = numbersArr[0];
            }
            else if (numbersArr[1] < numbersArr[2])
            {
                min = numbersArr[1];
            }
            else
            {
                min = numbersArr[2];
            }
            return min;
        }

        // Вывод последовательности Фиббоначчи, в которой последний элемент меньше заданного числа
        static void FibbSequence(int n)
        {
            int i = 0;
            int tekElem;

            while ((tekElem = Fibb(i)) < n) // while (Fibb(i) < n)
            {
                Console.Write(tekElem + " "); // Console.Write(Fibb(i));
                i++;
            }
        }

        // вычисление n-ного элемента последовательности Фиббоначчи
        static int Fibb(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return (Fibb(n - 1) + Fibb(n - 2));
            }
        }
    }
}
