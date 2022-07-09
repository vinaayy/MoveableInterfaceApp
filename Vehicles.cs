using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveablePolymorphismApp.Model
{
    public  abstract class Vehicles:IMovable
    {
        private string _company;
        private int _year;
        private string _model;

        public Vehicles(string company , int year , string model)
        {
            _company = company;
            _year = year;
            _model = model;
        }
        public abstract void Move();
        public string Company
        {
            get { return _company; }
        }
        public int Year
        {
            get { return _year; }
        }
        public string Model
        {
            get { return _model; }
        }

    }
    

    public class Car : Vehicles
    {
        public Car(string company, int year, string model):base(company , year , model)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Car Moving...");
        }
    }

    public class Bike : Vehicles
    {
        public Bike(string company, int year, string model) : base(company, year, model)
        {

        }
        public override void Move()
        {
            Console.WriteLine("Bike Moving...");
        }
    }

    public class Truck : Vehicles
    {
        public Truck(string company, int year, string model) : base(company, year, model)
        {

        }
        public override void Move()
        {
            Console.WriteLine("Truck Moving...");
        }
    }
}
