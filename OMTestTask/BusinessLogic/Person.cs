using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMTestTask.BusinessLogic
{
    public abstract class Person
    {
        public int Number { get; private set; }

        public string Name { get; private set; }

        public Person(int number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}
