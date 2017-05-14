using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.BusinessLogic
{
    public abstract class MoneyOperation : Operation
    {
        public decimal DeltaMoney { get; private set; }

        public MoneyOperation(Employee creator, Account account, decimal deltaMoney)
            : base(creator, account)
        {
            DeltaMoney = deltaMoney;
        }
    }
}
