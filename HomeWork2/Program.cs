using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;

            if (!TryEnterNumberFromConsole(out number))
            {
                Console.Read();
                return;
            }
            else if (number == 0)
            {
                Console.WriteLine("Число должно быть больше нуля!");
                Console.Read();
                return;
            }

            int[] unsortedNumbersArray = GenerateNumbersArrayOfSize(number);

            Console.WriteLine("Сгенерированный массив случайных чисел размером, заданным введенным числом: ");
            PrintArray(unsortedNumbersArray);

            int[] sortedNumbersArray = BubbleSortOfArray(unsortedNumbersArray);

            Console.WriteLine("Отсортированный массив чисел: ");
            PrintArray(sortedNumbersArray);

            Console.ReadLine();
        }

        static bool TryEnterNumberFromConsole(out uint number)
        {
            Console.Write("Введите целое число: ");

            string numberAsString = Console.ReadLine();

            if (!(uint.TryParse(numberAsString, out number)))
            {
                Console.Write("Ввели не число!");
                return false;
            }

            return true;
        }

        static int[] GenerateNumbersArrayOfSize(uint number)
        {
            int[] numbersArray = new int[number];
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                numbersArray[i] = rnd.Next();
            }
            return numbersArray;
        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        // Сортировка массива алгоритмом пузырьковой сортировки
        // Будет идти до определенного элемента (так как последнее число и 'n'[0,1,...,n] чисел до него уже можно не сравнивать)
        static int[] BubbleSortOfArray(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                for (int j = 0; j < numbersArray.Length - i - 1; j++)
                {
                    if (numbersArray[j] > numbersArray[j + 1])
                    {
                        int tempElem = numbersArray[j + 1];
                        numbersArray[j + 1] = numbersArray[j];
                        numbersArray[j] = tempElem;
                    }
                }
            }

            return numbersArray;
        }
    }
}
