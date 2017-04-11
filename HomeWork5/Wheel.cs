using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Wheel : Detail, IRotatable
    {
        private uint _number;
        private Car _ownerCar;

        public uint Number
        {
            get
            {
                return _number;
            }
        }

        public override int Weight { get; set; }
        public override string Name { get; set; } = "Колесо";

        public Wheel(uint number, Car ownerCar)
        {
            _number = number;
            _ownerCar = ownerCar;
        }

        public void Move()
        {
            Console.WriteLine("Колесо №" + Number + " машины " + _ownerCar.Model + " вращается.");
        }
    }
}
