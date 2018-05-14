using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Modules
{
    /// <summary>
    /// Легковая машина
    /// </summary>
    public class PassengerCar : Trans
    {
        public PassengerCar(string m, double s, string numb, double lif_pow)
               : base(m, numb, s, lif_pow) { }

        public override void Print()
        {
            Console.WriteLine("Модель: {0} \nМаксимальная скорость {1} \nНомер: {2} \nГрузоподьемность: {3} ", model, speed, number, liftPower);
            Console.WriteLine();
        }
    }
}
