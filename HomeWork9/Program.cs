using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class MathParser
    {
        public static double Example(char[] exp)
        {
            return ParseSummands(exp, 0);
        }

        public static double ParseSummands(char[] exp, int index)
        {
            double x = ParseFactors(exp, ref index);
            while (true)
            {
                char operators = exp[index];
                if (operators != '+' && operators != '-')
                {
                    return x;
                }
                index++;
                double y = ParseFactors(exp, ref index);
                if (operators == '+')
                {
                    x += y;
                }
                else
                {
                    x -= y;
                }
            }
        }

        public static double ParseFactors(char[] exp, ref int index)
        {
            double x = GetDouble(exp, ref index);
            while (true)
            {
                char operators = exp[index];
                if (operators != '/' && operators != '*')
                {
                    return x;
                }
                index++;
                double y = GetDouble(exp, ref index);
                if (operators == '/' && y != 0)
                {
                    x /= y;
                }
                else if (operators == '*')
                {
                    x *= y;
                }
            }
        }

        public static double GetDouble(char[] exp, ref int index)
        {
            string str = "";
            while ((exp[index] >= 48 && exp[index] <= 57) || exp[index] == 46)
            {
                str += exp[index].ToString();
                index++;
                if (index == exp.Length)
                {
                    index--;
                    break;
                }
            }

            return double.Parse(str); // Выдаст исключение при попытке преобразовать строку, содержащую число с точкой, (Н.: 50.5) в тип числа с плавающей запятой!!!
        }
    }

    class Program
    {
        enum Operation
        {
            Plus = 1,
            Minus,
            Multiply,
            Divide
        }

        static double Calculate(double oper1, double oper2, Operation op)
        {
            double result;

            switch (op)
            {
                case Operation.Plus:
                    result = oper1 + oper2;
                    break;
                case Operation.Minus:
                    result = oper1 - oper2;
                    break;
                case Operation.Multiply:
                    result = oper1 * oper2;
                    break;
                case Operation.Divide:
                    result = oper1 / oper2;
                    break;
                default:
                    result = 0.0; // на самом деле тут правильнее кидать исключение!!!
                    break;
            }

            return result;
        }

        static double ParseExpression(string expression)
        {
            Operation operation;
            double result = default(Double);
            int position;
            //int positionPlus = expression.IndexOf('+');
            //int positionMinus = expression.IndexOf('-');
            //int positionMultiply = expression.IndexOf('*');
            //int positionDivide = expression.IndexOf('/');
            int positionPlus = expression.LastIndexOf('+');
            int positionMinus = expression.LastIndexOf('-');
            int positionMultiply = expression.LastIndexOf('*');
            int positionDivide = expression.LastIndexOf('/');

            Console.WriteLine("Позиции операций в выражении:");

            Console.WriteLine(positionPlus);
            Console.WriteLine(positionMinus);
            Console.WriteLine(positionMultiply);
            Console.WriteLine(positionDivide);

            Console.WriteLine("-----");

            //Console.WriteLine(positionPlus + ' ' + positionMinus + ' ' + positionMultiply + ' ' + positionDivide);

            if (positionPlus > 0)
            {
                operation = Operation.Plus;
                position = positionPlus;

            }
            else if (positionMinus > 0)
            {
                operation = Operation.Minus;
                position = positionMinus;
            }
            else if (positionMultiply > 0)
            {
                operation = Operation.Multiply;
                position = positionMultiply;
            }
            else if (positionDivide > 0)
            {
                operation = Operation.Divide;
                position = positionDivide;
            }
            else
            {
                operation = default(Operation); // 0
                position = 0;
            }


            string oper1 = expression.Remove(position);
            string oper2 = expression.Remove(0, position + 1);

            Console.WriteLine("Операнды, на которые разбито выражение:");

            Console.WriteLine(oper1);
            Console.WriteLine(oper2);

            Console.WriteLine("-----");

            Console.WriteLine("Результаты преобразования операндов в число типа double:");

            Double.TryParse(oper1, out double operand1);
            Console.WriteLine(operand1);
            Double.TryParse(oper2, out double operand2);
            Console.WriteLine(operand2);

            Console.WriteLine("-----");
            Console.WriteLine("");

            if (operand1 == 0)
            {
                operand1 = ParseExpression(oper1);
            }

            if (operand2 == 0)
            {
                operand2 = ParseExpression(oper2);
            }
            
            result = Calculate(operand1, operand2, operation);
            /*
            if (operand1 != 0 && operand2 != 0)
            {
                result = Calculate(operand1, operand2, operation);
            }
            */

            return result;
            
            //double chislo = Double.Parse(oper1);
            //Console.WriteLine(chislo);

            //Decimal.TryParse(inputString, out Decimal result)); // рабочая штуковина!!!

            //if ()

            /*
            if (positionPlus != 0 && positionMinus != 0)
            {
                Operation operation = positionPlus < positionMinus ? Operation.Plus : Operation.Minus;
                int position = positionPlus < positionMinus ? positionPlus : positionMinus;
            }
            //Console.WriteLine(inputString);
            */
        }

        static void Main(string[] args)
        {
            Console.Write("Введите пример : ");
            //string example = Console.ReadLine();
            //string example = "7,55*10+3*5/10-7*2/4+5-1,5*5/2+1,25-0,1*5-6,5"; // правильный результат: 69
            //string example = "50*2-75+15/3"; // правильный результат: 30
            string example = "50,5*2-0,5+15/3+1,5"; // правильный результат: 107
            Console.Write("Ответ : ");
            Console.Write(MathParser.Example(example.ToCharArray()));
            //Console.Write(MathParser.Example(example.ToCharArray()).ToString());

            ///
            //string str = "50,5";
            //double chislo = Double.Parse(str);
            //Console.WriteLine(chislo);
            //double a = 50.5;
            //Console.WriteLine(a.ToString());
            ///
            
            //QuadraticAlgorithmExecutionTime q = new QuadraticAlgorithmExecutionTime();
            //q.LeadTime(2, 2);

            Console.Read();

            /*
            Console.WriteLine("----->Программа для парсинга арифметических выражений.<-----");
            Console.WriteLine("Выражение может содержать числа с плавающей точкой, а также операции +, -, *, /");
            Console.WriteLine("");
            Console.WriteLine("Введите выражение:");
            string inputString = Console.ReadLine();
            Console.WriteLine("");
            //string inputString = "-0,5--10,5"; // правильный результат: -13
            //string inputString = "-0,5-10,5-1,0*3+1"; // правильный результат: -13
            //string inputString = "7,55*10+3*5/10-7*2/4+5-1,5*5/2+1,25-0,1*5-6,5"; // правильный результат: 69
            //Console.WriteLine(inputString.Length);
            //Console.WriteLine(inputString[44]);

            try
            {
                Console.WriteLine("Результат вычисления выражения: " + ParseExpression(inputString));
            }
            catch (Exception exc)
            {
                Console.WriteLine("В выражении обнаружена ошибка, вычисление невозможно!");
            }

            Console.Read();
            */

            /*
            //double result = 
            char[] operations = new char[] { '*', '/', '+', '-' };
            int positionPlus = inputString.IndexOf('+');
            int positionMinus = inputString.IndexOf('-');
            if (positionPlus != 0 && positionMinus != 0)
            {
                Operation operation = positionPlus < positionMinus ? Operation.Plus : Operation.Minus;
                int position = positionPlus < positionMinus ? positionPlus : positionMinus;
            }
            Console.WriteLine(inputString);
            */



            /*
            string inputString = Console.ReadLine();
            //string inputString = "HelloWorld";
            char symbol = 'W';
            //decimal number = Decimal.TryParse(Console.ReadLine());
            Console.WriteLine(Decimal.TryParse(inputString, out Decimal result)); // рабочая штуковина!!!
            int positionNumber = inputString.IndexOf(symbol);
            Console.WriteLine(inputString.All(Char.IsNumber));
            Console.WriteLine(positionNumber);
            Console.Read();
            */

            /*
            Console.WriteLine("Нажмите клавишу 'Esc'!");

            int codeKey = Console.Read();
            char myChar = (char)codeKey;

            Console.WriteLine(codeKey);
            Console.WriteLine(myChar);
            Console.WriteLine(" ");

            Console.Read();

            Console.ReadLine();
            */

            /*
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Вы нажали клавишу 'Esc'");
            }
            else
            {
                Console.WriteLine("Вы нажали какую-то другую клавишу!");
            }

            Console.Read();
            */

            /*
            Console.WriteLine(OptionalParam(x: 2, y: 3));

            //Необязательный параметр z использует значение по умолчанию
            Console.WriteLine(OptionalParam(y: 2, x: 3, s: 10));

            Console.ReadLine();
            */

            /*
            Console.WriteLine("Введите выражение:");
            int number = Int32.Parse(Console.ReadLine()); // бросает исключение, если строка содержит что-то кроме цифр!
            Console.ReadLine();
            */

            /*
            List<double> numbersList = new List<double>();
            List<char> operaionsList = new List<char>();
            string numberAsString = "";

            Console.WriteLine("Введите выражение:");
            string expression = Console.ReadLine();

            for (int i = 0; i < expression.Length; i++)
            {
                while (expression[i] == '/' || expression[i] == '*' || expression[i] == '+' || expression[i] == '-')
                {
                    numberAsString += expression[i];
                }

                //numbersList.Add((double)numberAsString);

                if (expression[i] == '/' || expression[i] == '*' || expression[i] == '+' || expression[i] == '-')
                {
                    operaionsList.Add(expression[i]);
                }
            }

            Console.WriteLine(expression[0]);
            Console.WriteLine(expression[1]);

            Console.WriteLine(expression);
            Console.Read();
            */




            /*
            // Пример алгоритма сложности O(n^2)
            // Сортировка массива алгоритмом пузырьковой сортировки
            // Будет идти до определенного элемента (так как последнее число и 'n'[0,1,...,n] чисел до него уже можно не сравнивать)
            static int[] BubbleSortOfArray(int[] numbersArray)
            {
                for (int i = 0; i < numbersArray.Length - 1; i++)
                {
                    for (int j = 0; j < numbersArray.Length - i - 1; j++)
                    {
                        if (numbersArray[j] > numbersArray[j + 1])
                        {
                            int tempElem = numbersArray[j + 1];
                            numbersArray[j + 1] = numbersArray[j];
                            numbersArray[j] = tempElem;
                        }
                    }
                }

                return numbersArray;
            }
            */
        }
    }
}
