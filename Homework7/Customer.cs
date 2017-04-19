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

        public Customer(string FIO) : base(FIO)
        {
            //
        }
    }
}
