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

            Console.WriteLine(number1AsString.Length);
            Console.WriteLine(number2AsString.Length);

            //int minNumber = 0;
            int difference = 0;


            if (number1AsString != number2AsString)
            {
                difference = Math.Abs(number1AsString.Length - number2AsString.Length);
                Console.WriteLine(difference);

                string additionalStr = new String('0', difference);
                Console.WriteLine(additionalStr);

                if (number1AsString.Length < number2AsString.Length)
                {
                    number1AsString = additionalStr + number1AsString;
                }
                else
                {
                    number2AsString = additionalStr + number2AsString;
                }
            }



            //Console.WriteLine(minNumber);

            Console.WriteLine(number1AsString + ", " + number2AsString);
            Console.Read();
        }
    }
}
