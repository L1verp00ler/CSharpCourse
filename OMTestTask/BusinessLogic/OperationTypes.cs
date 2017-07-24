using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMTestTask.BusinessLogic
{
    [Flags]
    public enum OperationTypes
    {
        None = 0,
        OpenAccount = 0b1,
        CloseAccount = 0b10,
        PullMoney = 0b100,
        PushMoney = 0b1000
    }
}
