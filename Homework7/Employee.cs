﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Employee : Person
    {
        public override string FIO { get; set; }
        public uint PersonnelNumber { get; private set; }
        public OperationType AccessLevel { get; set; }
        //public string AccessLevel { get; set; }
        public bool isBusy = false;

        /*
        public Employee()
        {

        }
        */

        public Employee(string FIO, uint personnelNumber, OperationType accessLevel)
            : base(FIO)
        {
            this.FIO = FIO;
            this.PersonnelNumber = personnelNumber;
            this.AccessLevel = accessLevel;
        }

        public void ServiceCustomer()
        {

        }
    }
}
