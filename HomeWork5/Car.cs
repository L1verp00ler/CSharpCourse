using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Car : Detail
    {
        public override int Weight { get; set; }
        public override string Name { get; set; } = "Какая-то неизвестная модель машины";

        public Car(uint numberOfWheels, uint numberOfDoors)
        {
            
        }
    }
}
