using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMTestTask.BusinessLogic
{
    public class OpenOperation : Operation
    {
        public OpenOperation(Employee creator, Account account)
            : base(creator, account)
        {
        }

        public override void Apply()
        {
            Account.Open();
        }
    }
}
