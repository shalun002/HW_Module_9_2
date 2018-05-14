using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Modules
{
    /// <summary>
    /// Грузовик
    /// </summary>
    public class Truck : Trans
    {
        public bool trailer;  // прицеп

        public Truck(string m, double s, string numb, double lif_pow, bool tr)
            : base(m, numb, s, lif_pow)
        {
            trailer = tr;
            if (trailer == true)
                liftPower *= 2;
        }
        public override void Print()
        {
            Console.WriteLine("Модель: {0} \nМаксимальная скорость {1} \nНомер: {2} \nГрузоподьемность: {3} \nНаличие прицепа: {4}", model, speed, number, liftPower, trailer);
            Console.WriteLine();
        }
    }
}