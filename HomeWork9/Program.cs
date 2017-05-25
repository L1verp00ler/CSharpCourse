using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbersList = new List<double>();
            List<char> operaionsList = new List<char>();
            string numberAsString = "";

            Console.WriteLine("Введите выражение:");
            string expression = Console.ReadLine();

            for (int i = 0; i < expression.Length; i++)
            {
                while (expression[i] == '/' || expression[i] == '*' || expression[i] == '+' || expression[i] == '-')
                {
                    numberAsString += expression[i];
                }

                //numbersList.Add((double)numberAsString);

                if (expression[i] == '/' || expression[i] == '*' || expression[i] == '+' || expression[i] == '-')
                {
                    operaionsList.Add(expression[i]);
                }
            }

            Console.WriteLine(expression[0]);
            Console.WriteLine(expression[1]);

            Console.WriteLine(expression);
            Console.Read();

            /*
            // Пример алгоритма сложности O(n^2)
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
            */
        }
    }
}
