namespace NaqliyyatParki
{
    internal partial class Program
    {
        class Car : ITransport
        {
            public double FuelEfficiency { get; set; }
            public double FuelCost { get; set; }

            public double Speed => 60; 

            public double FuelConsumption => FuelEfficiency; 

            public double TripCost(double distance)
            {
                double fuelNeeded = distance / FuelEfficiency;
                return fuelNeeded * FuelCost;
            }
        }
    }

}

