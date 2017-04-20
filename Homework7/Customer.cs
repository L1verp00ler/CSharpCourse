using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Customer : Person
    {
        public override string FIO { get; set; }
        public uint ID { get; private set; }

        /*
        public Customer()
        {

        }
        */

        public Customer(string FIO, uint ID) : base(FIO)
        {
            this.ID = ID;
        }
    }
}
