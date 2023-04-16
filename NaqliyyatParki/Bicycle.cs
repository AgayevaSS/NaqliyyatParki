namespace NaqliyyatParki
{
    internal partial class Program
    {
        class Bicycle : ITransport
        {
            public double Speed => 15; 

            public double FuelConsumption => 0; 

            public double TripCost(double distance)
            {
                return 0; 
            }
        }
    }

}

