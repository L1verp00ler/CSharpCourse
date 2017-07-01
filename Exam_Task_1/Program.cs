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
            uint number = 0;
            uint result;

            Console.WriteLine("Программа для преобразование целого числа к цифре.");
            Console.Write("Введите целое число: ");

            try
            {
                number = UInt32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод!");
                Console.Read();
                return;
            }

            if (number / 10 == 0)
            {
                Console.WriteLine(number);
                Console.Read();
            }
            else
            {
                result = TransformNumberInDigit(number);
                Console.WriteLine(result);
                Console.Read();
            }
        }

        static uint TransformNumberInDigit(uint number)
        {
            uint resultNumber = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                //Console.WriteLine(number.ToString()[i]);
                
                resultNumber += UInt32.Parse(number.ToString()[i].ToString());
            }
            if (resultNumber / 10 == 0)
            {
                return resultNumber;
            }
            else
            {
                return TransformNumberInDigit(resultNumber);
            }
            //
            //return 0;
        }
    }
}
