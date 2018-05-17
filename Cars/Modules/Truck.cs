using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Грузовик (марка, номер, скорость, грузоподъемность, наличие прицепа, при этом если есть прицеп, то грузоподъемность увеличивается в два раза) */

namespace Cars.Modules
{
    /// <summary>
    /// Грузовик
    /// </summary>
    public class Truck : Trans
    {
        public bool Trailer { get; set; }   // прицеп

        public override void Print()
        {
            Console.WriteLine("Грузовик: {0} \nМаксимальная скорость: {1} \nНомер: {2} \nНаличие прицепа: {3} \nГрузоподьемность: {4}", Model, Speed, Number, Trailer, CarryingCapacity);
            Console.WriteLine();
        }
    }
}