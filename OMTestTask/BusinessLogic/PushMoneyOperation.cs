using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMTestTask.BusinessLogic
{
    public class PushMoneyOperation : MoneyOperation
    {
        public PushMoneyOperation(Employee creator, Account account, decimal deltaMoney)
            : base(creator, account, deltaMoney)
        {
        }

        public override void Apply()
        {
            Account.IncreaseMoney(DeltaMoney);
        }
    }
}
