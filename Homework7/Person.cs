using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    abstract class Person
    {
        public abstract string FIO { get; set; }

        /*
        public Person()
        {

        }
        */

        public Person(string FIO)
        {
            this.FIO = FIO;
        }
    }
}
