using System;
using System.Linq;

namespace Lesson6_TestTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите какой-нибудь текст: ");
            string stringFromUser = Console.ReadLine();

            if (stringFromUser.Length == 0)
            {
                Console.WriteLine("Строка не должна быть пустой!");
                Console.Read();
                return;
            }

            /// можно также переписать через тернарный оператор
            Console.Write("Строка с перевернутыми словами: ");
            // Если в строке у нас только буквы и цифры, то переворачиваем ее целиком (без доп преобр-ий)
            if (stringFromUser.All(Char.IsLetterOrDigit))
            {
                Console.WriteLine(StringReverse(stringFromUser));
            }
            else
            {
                Console.WriteLine(WordReverseInString(stringFromUser));
            }

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

        // Переворот слов в строке (и слов с числами)
        static string WordReverseInString(string inputString)
        {
            string tempStr = "";
            string resultStr = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (Char.IsLetterOrDigit(inputString[i]))
                {
                    tempStr += inputString[i];
                }
                else
                {
                    if (tempStr != "")
                    {
                        resultStr += StringReverse(tempStr);
                    }
                    tempStr = "";
                    resultStr += inputString[i];
                }
            }

            return resultStr;
        }
    }
}
