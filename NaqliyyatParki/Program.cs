using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaqliyyatParki
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { FuelEfficiency = 10, FuelCost = 1.5 };
            Bicycle bicycle = new Bicycle();
            Motorcycle motorcycle = new Motorcycle { FuelEfficiency = 20, FuelCost = 2 };

            double distance = 50; 

            Console.WriteLine("Car trip cost: " + car.TripCost(distance));
            Console.WriteLine("Bicycle trip cost: " + bicycle.TripCost(distance));
            Console.WriteLine("Motorcycle trip cost: " + motorcycle.TripCost(distance));
        }


        interface ITransport
        {
            double Speed { get; }
            double FuelConsumption { get; }
            double TripCost(double distance);
        }
    }

}

