using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Body : Detail, IRotatable, IDoor
    {
        private Car _ownerCar;

        public override int Weight { get; set; }
        public override string Name { get; set; } = "Рама";

        public Body(Car ownerCar)
        {
            _ownerCar = ownerCar;
        }

        public void Move()
        {
            Console.WriteLine("Машина " + _ownerCar.Model + " едет.");
        }

        public void Open()
        {
            Console.WriteLine("Увы, это не дверь!");
        }
    }
}
