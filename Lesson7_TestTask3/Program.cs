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

            // Проверка на ввод недопустимых символов
            if (!number1AsString.All(Char.IsDigit) || !number2AsString.All(Char.IsDigit))
            {
                Console.WriteLine("Вы допустили ошибку при вводе чисел!");
                Console.Read();
                return;
            }

            Console.WriteLine("Длина первой строки: " + number1AsString.Length);
            Console.WriteLine("Длина второй строки: " + number2AsString.Length);

            //int minNumber = 0;
            int difference = 0;

            // Если строки разной длины, то дополняем строку меньшей длины нулями до длины второй строки
            if (number1AsString != number2AsString)
            {
                difference = Math.Abs(number1AsString.Length - number2AsString.Length);
                Console.WriteLine("Разница между строками (число символов): " + difference);

                string additionalStr = new String('0', difference);
                Console.WriteLine("Добавочная строка (нули): " + additionalStr);

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

            /// Пока что поддерживает сложение чисел в сумме, дающих не больше 9!!! (т.е. не реализован перенос по разрядам)
            // Теперь строки равны и мы можем выполнять преобразования (возможно, можно было и без этого)
            for (int i = number1AsString.Length - 1; i >= 0; i--)
            {
                int sum = Int32.Parse(number1AsString[i].ToString()) + Int32.Parse(number2AsString[i].ToString());
                Console.WriteLine(sum);
                resultString += sum.ToString();
            }

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
