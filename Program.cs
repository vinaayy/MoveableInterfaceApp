using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveablePolymorphismApp.Model;

namespace MoveablePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicles[] v = new Vehicles[3];
            v[0] = new  Car("Tata", 2018, "Tiago");
            v[1] = new Bike("Honda", 2022, "Activa");
            v[2] = new Truck("Mahindra", 2010, "BigTruck");
            StartRace(v);
        }
        public static void StartRace(Vehicles[]  movables)
        {
            foreach (Vehicles vehicle in movables )
            {
                PrintDetails(vehicle);
                vehicle.Move();
            }
        }

        public static void PrintDetails(Vehicles obj)
        {
            Console.WriteLine("\nVehicle Details :");
            Console.WriteLine("Company : "+obj.Company);
            Console.WriteLine("Year    : "+obj.Year);
            Console.WriteLine("Model   : "+obj.Model);
        }
    }
}
