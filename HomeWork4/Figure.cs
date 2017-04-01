using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    abstract class Figure
    {
        public const float PI = 3.14f;

        public abstract string Name { get; }

        // Абстрактный метод для получения периметра
        public abstract float Perimeter();
        // Абстрактный метод для получения площади
        public abstract float Area();
    }
}
