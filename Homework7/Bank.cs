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
        public List<Employee> employeesList;
        public List<Account> accountsList;
        public List<Customer> customersList;

        public void RecruitEmployee(Employee employee)
        {

        }

        public Employee findFreeEmployeeOnRequest()
        {
            Employee emp = new Employee("fbshf", 123);
            return emp;
        }
    }
}
