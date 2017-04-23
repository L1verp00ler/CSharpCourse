using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Account
    {
        public uint Number { get; private set; }
        public bool State { get; private set; }
        public decimal Balance { get; private set; }
        public Customer Owner { get; private set; }
        public List<Operation> operationsHistory; // = new List<Operation>();

        public Account(uint number, Customer owner)
        {
            this.Number = number;
            this.State = true;
            this.Balance = 0;
            this.Owner = owner;
        }

        public void Open()
        {
            this.State = true;
        }

        public void Close()
        {
            this.State = false;
        }

        public void PutMoney(decimal sum)
        {
            this.Balance += sum;
        }

        public void WithdrawMoney(decimal sum)
        {
            if (this.Balance < sum)
            {
                Console.WriteLine("Недостаточно средств для проведения операции!");
            }
            else
            {
                this.Balance -= sum;
            }
        }
    }
}
