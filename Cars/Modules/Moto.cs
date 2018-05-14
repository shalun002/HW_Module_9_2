using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Modules
{
    /// <summary>
    /// Мотоцикл
    /// </summary>
    public class Motorcycle : Trans
    {
        public bool stroller;  // коляска

        public Motorcycle(string m, double s, string numb, double lif_pow, bool str)
            : base(m, numb, s, lif_pow)
        {
            stroller = str;
            if (str == false)
                liftPower = 0;
            else
                liftPower = lif_pow;
        }
        public override void Print()
        {
            Console.WriteLine("Модель: {0} \nМаксимальная скорость {1} \nНомер: {2} \nГрузоподьемность: {3} \nНаличие коляски: {4}", model, speed, number, liftPower, stroller);
            Console.WriteLine();
        }
    }
}