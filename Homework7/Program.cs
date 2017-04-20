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

                                uint personnelNumber = (uint)bank.employeesList.Count; //uint personnelNumber = bank.employeesList == null ? 0 : (uint)bank.employeesList.Count; // ??
                                Employee newEmployee = new Employee(FIO, personnelNumber);

                                bank.RecruitEmployee(newEmployee);
                                break;
                            case "F":
                                Console.Write("Введите ФИО струдника: ");
                                string employeeFIO = Console.ReadLine();

                                bank.FindEmployeeByFIO(employeeFIO);
                                break;
                            case "L":
                                if (bank.employeesList.Count == 0) // if (bank.employeesList == null)
                                {
                                    Console.WriteLine("Ни одного сотрудника не найдено!");
                                }
                                else
                                {
                                    Console.WriteLine("Список наших сотрудников:");
                                    foreach (Employee employee in bank.employeesList)
                                    {
                                        Console.WriteLine(employee.personnelNumber + " " + employee.FIO + " " + employee.isBusy);
                                    }
                                }
                                break;
                        }
                        break;
                    case "C":
                        Console.WriteLine("Работа с клиентами.");
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
                                Console.WriteLine(employee.personnelNumber + " " + employee.FIO + " " + employee.isBusy);
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
