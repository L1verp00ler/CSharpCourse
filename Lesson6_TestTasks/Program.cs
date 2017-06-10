using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_TestTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите какой-нибудь текст: ");

            string stringFromUser = Console.ReadLine();

            Console.WriteLine();
            if (stringFromUser.Length == 0)
            {
                Console.WriteLine("Строка не должна быть пустой!");
                Console.Read();
                return;
            }

            // можно также переписать через тернарный оператор
            Console.Write("Перевернутая строка: ");
            // Если в строке у нас только буквы и цифры, то переворачиваем ее целиком (без доп преобр-ий)
            if (stringFromUser.All(Char.IsLetterOrDigit))
            {
                Console.WriteLine(StringReverse(stringFromUser));
            }
            else
            {
                Console.WriteLine(WordReverseInString(stringFromUser));
            }
            //Console.WriteLine("Перевернутая строка: " + WordReverseInString(stringFromUser));
            //Console.WriteLine("Перевернутая строка: " + StringReverse(stringFromUser));

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

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                // Не обрабатывает ситуацию, когда строка без знаков препинания!
                // Также можно проверять на палиндром (хотя вроде бы мало смысла, т.к. при этой проверке все равно исп-ся reverse)
                if (Char.IsLetter(inputString[i]))
                {
                    tempStr += inputString[i];
                }
                else
                {
                    if (tempStr != "")
                    {
                        resultStr += StringReverse(tempStr);
                    }
                    resultStr += inputString[i];
                }
            }

            return resultStr;
        }
    }
}
