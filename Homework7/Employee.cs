using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Employee : Person
    {
        public override string FIO { get ; set; }
        public uint personnelNumber;
        public bool isBusy = false;

        /*
        public Employee()
        {

        }
        */

        public Employee(string FIO, uint personnelNumber)
            : base(FIO)
        {
            this.FIO = FIO;
            this.personnelNumber = personnelNumber;
        }

        public void ServiceCustomer()
        {

        }
    }
}
