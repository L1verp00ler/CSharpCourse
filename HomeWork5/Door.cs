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
            string doorStateBefore = this.isOpenedDoor ? "открыта" : "закрыта";
            Console.WriteLine("Дверь №" + Number + " машины " + _ownerCar.Model + " была " + doorStateBefore + "."); // Вывод сообщения о состоянии двери до операции с ней. 
            this.isOpenedDoor = !this.isOpenedDoor;
            string doorStateAfter = this.isOpenedDoor ? "открыта" : "закрыта";
            Console.WriteLine("Теперь дверь №" + Number + " машины " + _ownerCar.Model + " " + doorStateAfter + "."); // Вывод сообщения о состоянии двери после операции с ней.
        }
    }
}
