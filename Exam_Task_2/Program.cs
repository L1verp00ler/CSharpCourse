using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int result;

            Console.WriteLine("Программа для перемножения чисел, возведенных в степень значением того же числа.");
            Console.Write("Введите целое число: ");

            try
            {
                number = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод!");
                Console.Read();
                return;
            }

            result = NumberPowMethod(number);
            Console.WriteLine(result);
            Console.Read();
        }

        static int NumberPowMethod(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * (int)Math.Pow(i, i);
            }
            
            return result;
        }
    }
}
