using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Легковая_машина (марка, номер, скорость, грузоподъемность)*/

namespace Cars.Modules
{
    /// <summary>
    /// Легковая машина
    /// </summary>
    public class PassengerCar : Trans
    {
        public override void Print()
        {
            Console.WriteLine("Легковая машина: {0} \nМаксимальная скорость: {1} \nНомер: {2} \nГрузоподьемность: {3} ", Model, Speed, Number, CarryingCapacity);
            Console.WriteLine();
        }
    }
}
