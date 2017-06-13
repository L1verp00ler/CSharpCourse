using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_TestTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Array reverse!!!
            string resultString = "";

            Console.Write("Введите первое большое число: ");
            string number1AsString = Console.ReadLine();

            Console.Write("Введите второе большое число: ");
            string number2AsString = Console.ReadLine();
            
            // Проверка на ввод пустой строки
            if (number1AsString == "" || number2AsString == "")
            {
                Console.WriteLine("Вы не ввели число(а)!");
                Console.Read();
                return;
            }

            // Проверка на ввод недопустимых символов (буквы, знаки препинания и прочая хрень)
            if (!number1AsString.All(Char.IsDigit) || !number2AsString.All(Char.IsDigit))
            {
                Console.WriteLine("Вы допустили ошибку при вводе чисел!");
                Console.Read();
                return;
            }

            Console.WriteLine("Длина первой строки: " + number1AsString.Length);
            Console.WriteLine("Длина второй строки: " + number2AsString.Length);

            int difference = 0;

            // Если строки разной длины, то дополняем строку меньшей длины нулями до длины второй строки
            if (number1AsString.Length != number2AsString.Length)
            {
                difference = Math.Abs(number1AsString.Length - number2AsString.Length); // вычисляем разницу в кол-ве символов между строками
                Console.WriteLine("Разница между строками (число символов): " + difference);

                string additionalStr = new String('0', difference); // формируем добавочную строку из нулей линой difference символов
                Console.WriteLine("Добавочная строка (нули): " + additionalStr);

                // соединяем добавочную строку с строкой меньшей длины, чтобы строки стали одинаковой длины
                if (number1AsString.Length < number2AsString.Length)
                {
                    number1AsString = additionalStr + number1AsString;
                }
                else
                {
                    number2AsString = additionalStr + number2AsString;
                }

                Console.WriteLine(number1AsString + ", " + number2AsString);
            }

            int sum = 0;
            int digit = 0;
            int box = 0; // По сути, вместо int можно использовать bool (хотяяя, стоит ли?)
            
            // Теперь строки равны и мы можем выполнять преобразования (возможно, можно было и без этого)
            for (int i = number1AsString.Length - 1; i >= 0; i--)
            {
                sum = Int32.Parse(number1AsString[i].ToString()) + Int32.Parse(number2AsString[i].ToString());
                digit = sum % 10 + box;
                int chislo = sum % 10;

                Console.WriteLine("Остаток от деления суммы двух текущих цифр на 10: " + chislo);
                Console.WriteLine("Сумма двух текущих цифр: " + sum);
                Console.WriteLine("Сумма цифр с учетом переноса из младшего разряда (и без учета переноса в старший разряд): " + digit);

                box = sum >= 10 ? 1 : 0;

                Console.WriteLine("Перенос в старший разряд: " + box);
                Console.WriteLine("-----");

                resultString += digit.ToString();
            }

            resultString = box > 0 ? resultString += box : resultString;

            resultString = StringReverse(resultString);

            Console.WriteLine(resultString);
            Console.Read();
        }

        // Переворот строки
        static string StringReverse(string inputString)
        {
            string reverseString = "";

            for (int i = inputString.Length - 1; i > -1; i--)
            {
                reverseString += inputString[i];
            }

            return reverseString;
        }
    }
}
