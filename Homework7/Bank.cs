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
            Console.WriteLine("Сотрудник " + newEmployee.FIO + " успешно принят на работу! Ему присвоен табельный номер - " + newEmployee.PersonnelNumber + ".");
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
                    Console.WriteLine(employee.PersonnelNumber + " " + employee.FIO + " " + employee.AccessLevel + " " + employee.isBusy);
                }
            }
        }

        // Найти свободного сотрудника, соответствующего запросу клиента
        public Employee FindFreeEmployeeOnRequest(OperationType operationType)
        {
            Employee employeeOnRequest = null;

            foreach (Employee employee in this.employeesList)
            {
                if (employee.AccessLevel == operationType)
                {
                    employeeOnRequest = employee;
                }
            }
            
            //Employee emp = new Employee("fbshf", 123, Operation.OpenAccount);
            return employeeOnRequest;
        }

        // Обслужить клиента
        /*
        public void RecruitEmployee(Employee newEmployee)
        {
            this.employeesList.Add(newEmployee);
            Console.WriteLine("Сотрудник " + newEmployee.FIO + " успешно принят на работу! Ему присвоен табельный номер - " + newEmployee.personnelNumber + ".");
        }
        */

        // Добавить нового клиента (ВРЕМЕННЫЙ МЕТОД)
        public void AddCustomer(Customer newCustomer)
        {
            this.customersList.Add(newCustomer);
            Console.WriteLine("Клиент " + newCustomer.FIO + " успешно добавлен! Ему присвоен ID - " + newCustomer.ID + ".");
        }
        //

        // Найти клиента по ФИО
        public void FindCustomerByFIO(string customerFIO)
        {
            bool isCustomerFound = false;

            foreach (Customer customer in this.customersList)
            {
                if (customer.FIO == customerFIO)
                {
                    Console.WriteLine("Клиент " + customer.FIO + " найден!");
                    isCustomerFound = true;
                    break;
                }
            }

            if (!isCustomerFound)
            {
                Console.WriteLine("Клиент с ФИО '" + customerFIO + "' не найден!");
            }
        }

        // Вывод списка клиентов
        public void GetAndPrintAllCustomers()
        {
            if (this.customersList.Count == 0) // if (bank.employeesList == null)
            {
                Console.WriteLine("Ни одного клиента не найдено!");
            }
            else
            {
                Console.WriteLine("Список наших клиентов:");
                foreach (Customer customer in this.customersList)
                {
                    Console.WriteLine(customer.FIO);
                }
            }
        }
    }
}
