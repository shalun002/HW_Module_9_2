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
        public string model;
        public string number;
        public double speed;
        public double liftPower;

        public Trans(string model, string number, double speed, double liftPower, bool b = false)
        {
            this.model = model;
            this.number = number;
            this.speed = speed;
            this.liftPower = liftPower;
        }

        public abstract void Print();
    }
}
