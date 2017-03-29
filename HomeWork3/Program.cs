using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string stringFromUser;

            Console.Write("Введите какой-нибудь текст: ");

            string stringFromUser = Console.ReadLine();

            if (stringFromUser.Length == 0)
            {
                Console.WriteLine("Строка не должна быть пустой!");
                Console.Read();
                return;
            }

            Console.WriteLine(stringFromUser.Length);

            if (IsPalindrom(stringFromUser))
            {
                Console.WriteLine("Строка является палиндромом!");
            } else
            {
                Console.WriteLine("Строка не является палиндромом!");
            }

            Console.WriteLine("Число слов во введенной Вами строке: " + WordCountInString(stringFromUser));

            Console.WriteLine("Перевернутая строка: " + StringReverse(stringFromUser));

            Console.Read();
        }

        static bool IsPalindrom(string stringFromUser)
        {
            if (stringFromUser.Length%2 == 0)
            {
                Console.WriteLine("Четное число символов в строке!");
                for (int i = 0, j = stringFromUser.Length - 1; i < stringFromUser.Length / 2; i++, j--)
                {
                    if (stringFromUser[i] != stringFromUser[j])
                    {
                        Console.WriteLine("{0} не равен {1}", stringFromUser[i], stringFromUser[j]);
                        return false;
                    } else
                    {
                        Console.WriteLine("{0} равен {1}", stringFromUser[i], stringFromUser[j]);
                    }
                }
                return true;
            } else 
            {
                Console.WriteLine("Нечетное число символов в строке!");
                for (int i = 0, j = stringFromUser.Length - 1; i < (stringFromUser.Length - 1) / 2; i++, j--)
                {
                    if (stringFromUser[i] != stringFromUser[j])
                    {
                        Console.WriteLine("{0} не равен {1}", stringFromUser[i], stringFromUser[j]);
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("{0} равен {1}", stringFromUser[i], stringFromUser[j]);
                    }
                }
                return true;
            }
        }

        static int WordCountInString(string stringFromUser)
        {
            string[] words = stringFromUser.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in words)
            {
                Console.WriteLine(str);
            }
            return words.Length;
        }

        // http://ru.stackoverflow.com/questions/146083/%D0%9A%D0%B0%D0%BA-%D0%BD%D0%B0-c-%D0%BF%D0%B5%D1%80%D0%B5%D0%B2%D0%B5%D1%80%D0%BD%D1%83%D1%82%D1%8C-%D1%81%D1%82%D1%80%D0%BE%D0%BA%D1%83-%D0%B1%D1%8B%D0%BB%D0%BE-123-%D1%81%D1%82%D0%B0%D0%BB%D0%BE-321
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
