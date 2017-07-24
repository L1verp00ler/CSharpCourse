using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMTestTask.BusinessLogic
{
    public abstract class Operation
    {
        public Employee Creator { get; private set; }

        public Account Account { get; private set; }

        public Operation(Employee creator, Account account)
        {
            Creator = creator;
            Account = account;
        }

        public abstract void Apply();
    }
}
