using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Wheel : Detail, IRotatable
    {
        public override int Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Move()
        {
            Console.WriteLine("");
        }
    }
}
