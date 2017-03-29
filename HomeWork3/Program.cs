using System;

namespace HomeWork3
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

            if (IsPalindrom(stringFromUser))
            {
                Console.WriteLine("Строка является палиндромом!");
            } else
            {
                Console.WriteLine("Строка не является палиндромом!");
            }
            Console.WriteLine();

            Console.WriteLine("Число слов во введенной Вами строке: " + WordCountInString(stringFromUser));
            Console.WriteLine();

            Console.WriteLine("Перевернутая строка: " + StringReverse(stringFromUser));

            Console.Read();
        }

        static bool IsPalindrom(string stringFromUser)
        {
            int number = stringFromUser.Length % 2 == 0 ? stringFromUser.Length / 2 : (stringFromUser.Length - 1) / 2;

            for (int i = 0, j = stringFromUser.Length - 1; i < number; i++, j--)
            {
                if (stringFromUser[i] != stringFromUser[j])
                {
                    return false;
                }
            }

            return true;
        }

        static int WordCountInString(string stringFromUser)
        {
            string[] words = stringFromUser.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        static string StringReverse(string stringFromUser)
        {
            string reverseString = "";

            for (int i = stringFromUser.Length - 1, j = 0; i > -1; i--, j++)
            {
                reverseString += stringFromUser[i];
            }

            return reverseString;
        }
    }
}
