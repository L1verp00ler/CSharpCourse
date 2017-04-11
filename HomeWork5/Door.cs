using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Door : Detail, IDoor
    {
        public bool isOpenedDoor = false;

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
        public override string Name { get; set; } = "Дверь";

        public Door(uint number, Car ownerCar)
        {
            _number = number;
            _ownerCar = ownerCar;
        }


        public void Open()
        {
            string doorState = this.isOpenedDoor ? "открыта" : "закрыта";
            Console.WriteLine("Дверь №" + Number + " машины " + doorState);
            this.isOpenedDoor = !this.isOpenedDoor;
        }
    }
}
