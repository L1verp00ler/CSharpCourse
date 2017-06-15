using System;

namespace HomeWork9
{
    class Program
    {
        enum Operation
        {
            Plus = 1,
            Minus,
            Multiply,
            Divide
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----->Программа для парсинга арифметических выражений.<-----");
            Console.WriteLine("Выражение может содержать числа с плавающей точкой, а также операции +, -, *, /");
            Console.WriteLine("");
            Console.WriteLine("Введите выражение:");
            string inputString = Console.ReadLine();
            //string inputString = "7,55*10+3*5/10-7*2/4+5-1,5*5/2+1,25-0,1*5-6,5"; // правильный результат: 69
            Console.WriteLine("");

            try
            {
                Console.WriteLine("Результат вычисления выражения: " + ParseExpression(inputString));
            }
            catch (Exception exc)
            {
                Console.WriteLine("В выражении обнаружена ошибка, вычисление невозможно!");
            }

            Console.Read();
        }

        static double ParseExpression(string expression)
        {
            Operation operation;
            double result = default(Double);
            int position;

            // Вычисляем позиции арифметических операций (крайнюю позицию, т.е. наибольшую)
            int positionPlus = expression.LastIndexOf('+');
            int positionMinus = expression.LastIndexOf('-');
            int positionMultiply = expression.LastIndexOf('*');
            int positionDivide = expression.LastIndexOf('/');

            // Определяем операцию и ее позицию в выражении, исходя из приоритетов (от + до /)
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

            // Разбиваем выражение на 2 операнда
            string oper1 = expression.Remove(position);
            string oper2 = expression.Remove(0, position + 1);

            // Пытаемся преобразовать каждый операнд к числу с плавающей точкой
            Double.TryParse(oper1, out double operand1);
            Double.TryParse(oper2, out double operand2);
            
            // Если преобразование в число не удалось, то пытаемся распарсить дальше (рекурсивно)
            if (operand1 == 0)
            {
                operand1 = ParseExpression(oper1);
            }

            if (operand2 == 0)
            {
                operand2 = ParseExpression(oper2);
            }

            // Выполняем операцию над операндами
            result = Calculate(operand1, operand2, operation);

            return result;
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
    }
}
