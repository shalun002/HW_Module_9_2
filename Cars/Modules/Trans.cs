using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*1. Создать абстрактный класс Trans с методами позволяющим вывести на экран информацию о транспортном средстве, а также определить грузоподъемность транспортного средства.*/

namespace Cars.Modules
{
    public abstract class Trans
    {
        public string Model { get; set; }
        public int Number { get; set; }
        public int Speed { get; set; }
        public double CarryingCapacity { get; set; }

        public abstract void Print();
    }
}
