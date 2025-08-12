using System.Reflection;

namespace VehicleRental
{
    public class RentalManager
    {
        private List<Vehicle> _vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle v)
        {
            _vehicles.Add(v);
        }

        public Vehicle? FindByModel(string model)
            => _vehicles.FirstOrDefault(v => v.Model.Equals(model, StringComparison.OrdinalIgnoreCase));

        // to be implemented
        public void CompareVehicles()
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                Car car = vehicle as Car;
                if (car == null)
                {
                    Console.WriteLine("That's not a car.");
                }
                else
                {
                    car.DisplayInfo();
                    Console.WriteLine($"Are {_vehicles[0].Model} and {vehicle.Model} the same?: {(_vehicles[0].Equals(vehicle) ? "Yes!" : "Nope")}");
                }


                Console.WriteLine();
            }
        }
    }
}
