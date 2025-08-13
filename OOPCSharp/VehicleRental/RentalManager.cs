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

        public void RentVehicle(string model, int hours)
        {
            var vehicle = FindByModel(model);

            if (vehicle == null)
            {
                Console.WriteLine("Vehicle not found.");
                return;
            }

            if (!vehicle.IsAvailable)
            {
                Console.WriteLine("The vehicle is not available.");
                return;
            }

            switch (vehicle)
            {
                case Car car:
                    Console.WriteLine("Processing special paperwork for car rental...");
                    break;
                case Motorcycle m:
                    Console.WriteLine("Ensure helmet is provided...");
                    break;
                case Bicycle b:
                    Console.WriteLine("Drive safe!");
                    break;
            }

            vehicle.IsAvailable = false;
            Console.WriteLine($"You've rented the {vehicle.Brand} {vehicle.Model} for {hours} hour(s).");
            Console.WriteLine();
        }
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
