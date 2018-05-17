using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Мотоцикл (марка, номер, скорость, грузоподъемность, наличие коляски, при этом если коляска отсутствует, то грузоподъемность равна 0)*/

namespace Cars.Modules
{
    /// <summary>
    /// Мотоцикл
    /// </summary>
    public class Motorcycle : Trans
    {
        public bool Stroller { get; set; }  // коляска

        public override void Print()
        {
            Console.WriteLine("Мотоцикл: {0} \nМаксимальная скорость {1} \nНомер: {2} \nГрузоподьемность: {3} \nНаличие коляски: {4}", Model, Speed, Number, CarryingCapacity, Stroller);
            Console.WriteLine();
        }
    }
}