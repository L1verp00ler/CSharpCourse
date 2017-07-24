using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMTestTask.BusinessLogic
{
    public class CloseOperation : Operation
    {
        public CloseOperation(Employee creator, Account account)
            : base(creator, account)
        {
        }

        public override void Apply()
        {
            Account.Close();
        }
    }
}
