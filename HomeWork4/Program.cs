using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill", "Gates");
            p1.Display(); // вызов метода Display из класса Person

            Person p2 = new Employee("Tom", "Johns", "UnitBank");
            p2.Display(); // вызов метода Display из класса Person

            Employee p3 = new Employee("Sam", "Toms", "CreditBank");
            p3.Display(); // вызов метода Display из класса Person
            Console.Read();
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string lName, string fName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public virtual void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string lName, string fName, string comp)
                : base(fName, lName)
        {
            Company = comp;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Место работы : " + Company);
        }
    }
}
