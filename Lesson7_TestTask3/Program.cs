using System;
using System.Linq;

namespace Lesson7_TestTask3
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("Вы ввели не число(а)!");
                Console.Read();
                return;
            }

            int difference = 0; // 1

            // Если строки разной длины, то дополняем строку меньшей длины нулями до длины второй строки
            if (number1AsString.Length != number2AsString.Length)
            {
                difference = Math.Abs(number1AsString.Length - number2AsString.Length); // вычисляем разницу в кол-ве символов между строками

                string additionalStr = new String('0', difference); // формируем добавочную строку из нулей длиной difference символов

                // соединяем добавочную строку с строкой меньшей длины, чтобы строки стали одинаковой длины
                if (number1AsString.Length < number2AsString.Length)
                {
                    number1AsString = additionalStr + number1AsString;
                }
                else
                {
                    number2AsString = additionalStr + number2AsString;
                }
            }

            int sum = 0; // 2
            int digit = 0; // 3
            int box = 0; // По сути, вместо int можно использовать bool (хотяяя, стоит ли?)
            
            // Теперь строки равны и мы можем выполнять преобразования (возможно, можно было и без этого)
            for (int i = number1AsString.Length - 1; i >= 0; i--)
            {
                // складываем текущие цифры из 2-ух строк
                sum = Int32.Parse(number1AsString[i].ToString()) + Int32.Parse(number2AsString[i].ToString());
                // берем от числа (суммы цифр) младший разряд и добавляем к нему перенос
                digit = sum % 10 + box;
                // если сумма текущих цифр > 10, то в хранилище помещаем 1, если нет, то 0 (для переноса в старший разряд)
                box = sum >= 10 ? 1 : 0;

                resultString += digit.ToString();
            }

            // так как цикл идет только по длине строк, то в конце нужно проверить, есть ли перенос в старший разряд
            resultString = box > 0 ? resultString += box : resultString;

            // Переворачиваем полученную строку
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
