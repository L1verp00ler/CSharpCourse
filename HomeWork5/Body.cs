using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Body : Detail, IRotatable, IDoor
    {
        public override int Weight { get; set; }
        public override string Name { get; set; } = "Рама";

        public void Move()
        {
            Console.WriteLine("Машина " + " едет.");
        }

        public void Open()
        {
            Console.WriteLine("Увы, это не дверь!");
        }
    }
}
