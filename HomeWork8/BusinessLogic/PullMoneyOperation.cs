using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.BusinessLogic
{
    public class PullMoneyOperation : MoneyOperation
    {
        public PullMoneyOperation(Employee creator, Account account, decimal deltaMoney)
            : base(creator, account, deltaMoney)
        {
        }

        public override void Apply()
        {
            Account.DecreaseMoney(DeltaMoney);
        }
    }
}
