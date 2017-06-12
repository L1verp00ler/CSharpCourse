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
            Console.Write("Введите первое большое число: ");
            string number1AsString = Console.ReadLine();

            Console.Write("Введите второе большое число: ");
            string number2AsString = Console.ReadLine();

            if (!number1AsString.All(Char.IsDigit) || !number2AsString.All(Char.IsDigit))
            {
                Console.WriteLine("Вы допустили ошибку при вводе чисел!");
                Console.Read();
                return;
            }

            Console.WriteLine(number1AsString + number2AsString);
            Console.Read();
        }
    }
}
