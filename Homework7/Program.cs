using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OperationType.OpenAccount);

            Bank bank = new Bank("НаеБанк");
            Console.WriteLine(">>>>>>>>> Добро пожаловать в " + bank.Name + "! <<<<<<<<<");

            do
            {
                Console.Write("\nВыберите действие: E - работа с сотрудниками, C - работа с клиентами, I - получение подробной информацию о банке: ");
                switch (Console.ReadLine())
                {
                    case "E":
                        Console.WriteLine("\n>>> Работа с сотрудниками");
                        Console.Write("Выберите действие: A - добавить нового сотрудника, F - поиск сотрудника по ФИО, L - получение списка всех сотрудников: ");
                        switch (Console.ReadLine())
                        {
                            case "A":
                                Console.WriteLine("\nПожалуйста, введите данные сотрудника!");
                                
                                Console.Write("ФИО: ");
                                string FIO = Console.ReadLine();
                                Console.Write("Уровень доступа (O(C) - открытие(закрытие) счета, P(W) - внесение(снятие) денег на(со) счет(а)): ");
                                string accessLevelAsString = Console.ReadLine();

                                OperationType accessLevel;
                                switch (accessLevelAsString)
                                {
                                    case "O":
                                        accessLevel = OperationType.OpenAccount;
                                        break;
                                    case "C":
                                        accessLevel = OperationType.CloseAccount;
                                        break;
                                    case "P":
                                        accessLevel = OperationType.PutMoney;
                                        break;
                                    case "W":
                                        accessLevel = OperationType.WithdrawMoney;
                                        break;
                                    default:
                                        accessLevel = OperationType.OpenAccount;
                                        break;
                                }

                                uint personnelNumber = (uint)bank.employeesList.Count; //uint personnelNumber = bank.employeesList == null ? 0 : (uint)bank.employeesList.Count; // ??
                                Employee newEmployee = new Employee(FIO, personnelNumber, accessLevel);

                                bank.RecruitEmployee(newEmployee);
                                break;
                            case "F":
                                Console.Write("Введите ФИО сотрудника: ");
                                string employeeFIO = Console.ReadLine();

                                bank.FindEmployeeByFIO(employeeFIO);
                                break;
                            case "L":
                                bank.GetAndPrintAllEmployees(); // Get подразумевает возврат чего-то - ПОПРАВИТЬ!!!
                                break;
                            default:
                                Console.WriteLine("Выбрано некорректное действие!");
                                break;
                        }
                        break;
                    case "C":
                        Console.WriteLine("\n>>> Работа с клиентами");
                        Console.Write("Выберите действие: S - обслужить клиента, F - поиск клиента по ФИО, L - получение списка всех клиентов: ");
                        switch (Console.ReadLine())
                        {
                            case "S":
                                Console.Write("Выберите действие: O - открыть счет, C - закрыть счет, P - положить денеги на счет, W - снять деньги со счета: ");
                                string operationTypeAsString = Console.ReadLine();

                                OperationType operationType;
                                switch (operationTypeAsString)
                                {
                                    case "O":
                                        operationType = OperationType.OpenAccount;
                                        break;
                                    case "C":
                                        operationType = OperationType.CloseAccount;
                                        break;
                                    case "P":
                                        operationType = OperationType.PutMoney;
                                        break;
                                    case "W":
                                        operationType = OperationType.WithdrawMoney;
                                        break;
                                    default:
                                        operationType = OperationType.OpenAccount;
                                        break;
                                }

                                Console.WriteLine("\nПожалуйста, введите данные клиента!");

                                Console.Write("ФИО: ");
                                string FIO = Console.ReadLine();

                                uint customerID = (uint)bank.customersList.Count; //uint personnelNumber = bank.employeesList == null ? 0 : (uint)bank.employeesList.Count; // ??
                                Customer newCustomer = new Customer(FIO, customerID);

                                bank.AddCustomer(newCustomer);

                                Employee employeeOnRequest = bank.FindFreeEmployeeOnRequest(operationType);
                                if (employeeOnRequest == null)
                                {
                                    Console.WriteLine("Сотрудника по Вашему запросу не найдено!");
                                    break;
                                }
                                Console.WriteLine("Сотрудник " + employeeOnRequest.FIO + " готов выполнить Ваш запрос!");
                                // TODO: здесь сотрудник должен инициировать операцию
                                break;
                            case "F":
                                Console.Write("Введите ФИО клиента: ");
                                string customerFIO = Console.ReadLine();

                                bank.FindCustomerByFIO(customerFIO);
                                break;
                            case "L":
                                bank.GetAndPrintAllCustomers();
                                break;
                            default:
                                Console.WriteLine("Выбрано некорректное действие!");
                                break;
                        }
                        break;
                    case "I":
                        Console.WriteLine("Инфа о банке:");

                        if (bank.employeesList.Count == 0)
                        {
                            Console.WriteLine("Ни одного сотрудника не найдено!");
                        }
                        else
                        {
                            Console.WriteLine("Список наших сотрудников:");
                            foreach (Employee employee in bank.employeesList)
                            {
                                Console.WriteLine(employee.PersonnelNumber + " " + employee.FIO + " " + employee.AccessLevel + " " + employee.isBusy);
                            }
                        }

                        if (bank.customersList.Count == 0)
                        {
                            Console.WriteLine("Ни одного клиента не найдено!");
                        }
                        else
                        {
                            Console.WriteLine("Список наших клиентов:");
                            foreach (Customer customer in bank.customersList)
                            {
                                Console.WriteLine(customer.FIO);
                            }
                        }

                        if (bank.accountsList.Count == 0)
                        {
                            Console.WriteLine("Ни одного счета не найдено!");
                        }
                        else
                        {
                            Console.WriteLine("Список счетов:");
                            foreach (Account account in bank.accountsList)
                            {
                                Console.WriteLine(account);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Выбрано некорректное действие!");
                        break;
                }
                Console.Write("\r\nДля повтора введите 'r', для выхода - любой символ: ");
            }
            while (Console.ReadLine() == "r");
        }
    }
}
