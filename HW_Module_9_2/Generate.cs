using Cars.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9_2
{
    public enum MotorcycleModel { Honda, Yamaha, IJ, URAL }
    public enum TruckModel { Man, Mersedes, VOLVO, Kamaz }
    public enum PassengerCarModel { Vaz, Audi, BMW, Pajero, Subaru }

    public class Generate
    {
        private Random rand = new Random();
        List<Trans> trans;

        public Generate()
        {
            trans = new List<Trans>();
        }

        private bool GenerateBool()
        {
            return rand.Next(0, 2) == 1;
        }

        public void GenerateMoto()
        {
            for (int i = 0; i <= 4; i++)
            {
                Motorcycle motorcycle = new Motorcycle();

                motorcycle.Model = ((MotorcycleModel)rand.Next(0, 4)).ToString();
                motorcycle.Speed = rand.Next(0, 300);
                motorcycle.Number = rand.Next(1, 20);
                motorcycle.Stroller = GenerateBool();
                motorcycle.CarryingCapacity = rand.Next(10, 20);

                if (motorcycle.Stroller == false)
                    motorcycle.CarryingCapacity = 0;
                else
                    motorcycle.CarryingCapacity = rand.Next(10, 50);
                trans.Add(motorcycle);
            }
        }

        public void GenerateTruck()
        {
            for (int i = 0; i <= 4; i++)
            {
                Truck truck = new Truck();
                truck.Model = ((TruckModel)rand.Next(0, 4)).ToString();
                truck.Speed = rand.Next(0, 200);
                truck.Number = rand.Next(1, 20);
                truck.CarryingCapacity = rand.Next(100, 500);
                truck.Trailer = GenerateBool();
                if (truck.Trailer == true)
                {
                    truck.CarryingCapacity = truck.CarryingCapacity * 2;
                }

                trans.Add(truck);
            }
        }

        public void GeneratePassengerCar()
        {
            for (int i = 0; i <= 5; i++)
            {
                PassengerCar passengerCar = new PassengerCar();
                passengerCar.Model = ((PassengerCarModel)rand.Next(0, 5)).ToString();
                passengerCar.Speed = rand.Next(0, 260);
                passengerCar.Number = rand.Next(1, 20);
                passengerCar.CarryingCapacity = rand.Next(10, 100);

                trans.Add(passengerCar);
            }
        }

        public void PrintAll()
        {
            foreach (Trans item in trans)
            {
                item.Print();
            }
        }

        public void FindTrans(int m)
        {
            foreach (Trans item in trans)
            {
                if (m < item.CarryingCapacity)
                    item.Print();
                else
                    Console.WriteLine("В вашем запросе нет совпадений");
            }
        }
    }
}