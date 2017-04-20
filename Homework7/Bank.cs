using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Bank
    {
        public bool isOpened = true;
        public List<Employee> employeesList = new List<Employee>(); // public List<Employee> employeesList = default(List<Employee>);
        public List<Account> accountsList = new List<Account>();
        public List<Customer> customersList = new List<Customer>();

        public string Name { get; private set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        // Прием нового сотрудника на работу
        public void RecruitEmployee(Employee newEmployee)
        {
            this.employeesList.Add(newEmployee);
            Console.WriteLine("Сотрудник " + newEmployee.FIO + " успешно принят на работу! Ему присвоен табельный номер - " + newEmployee.personnelNumber + ".");
        }

        // Найти сотрудника по ФИО
        public void FindEmployeeByFIO(string employeeFIO)
        {
            bool isEmployeeFound = false;

            foreach (Employee employee in this.employeesList)
            {
                if (employee.FIO == employeeFIO)
                {
                    Console.WriteLine("Сотрудник " + employee.FIO + " найден!");
                    isEmployeeFound = true;
                    break;
                }
            }

            if (!isEmployeeFound)
            {
                Console.WriteLine("Сотрудник с ФИО '" + employeeFIO + "' не найден!");
            }
        }

        // Вывод списка сотрудников
        public void GetAndPrintAllEmployees()
        {
            if (this.employeesList.Count == 0) // if (bank.employeesList == null)
            {
                Console.WriteLine("Ни одного сотрудника не найдено!");
            }
            else
            {
                Console.WriteLine("Список наших сотрудников:");
                foreach (Employee employee in this.employeesList)
                {
                    Console.WriteLine(employee.personnelNumber + " " + employee.FIO + " " + employee.isBusy);
                }
            }
        }

        // Найти свободного сотрудника, соответствующего запросу клиента
        public Employee findFreeEmployeeOnRequest()
        {
            Employee emp = new Employee("fbshf", 123);
            return emp;
        }
    }
}
