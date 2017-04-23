using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Operation
    {

        // TODO: допилить этот класс (в методе ниже, скорее всего, надо будет оставить только первый параметр - operationType!!!)

        public void Execute(OperationType operationType, Account account = null, decimal sum = default(Decimal))
        {
            Console.WriteLine(sum);
        }
    }
}
