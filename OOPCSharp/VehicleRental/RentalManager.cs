using System.Net.Http.Headers;
using System.Numerics;
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
        public void CompareVehicles(Vehicle v1, Vehicle v2)
        {
            if (v1 == null || v2 == null)
            {
                Console.WriteLine("One or both vehicles are null.");
                return;
            }

            Console.WriteLine($"Comparing {v1.Brand} {v1.Model} and {v2.Brand} {v2.Model}:");

            if (v1 is Car car1 && v2 is Car car2)
            {
                if (car1.SeatCount > car2.SeatCount)
                    Console.WriteLine($"{car1.Brand} {car1.Model} has more seats.");
                else if (car1.SeatCount < car2.SeatCount)
                    Console.WriteLine($"{car2.Brand} {car2.Model} has more seats.");
                else
                    Console.WriteLine("Both cars have the same amount of seats.");
            }

            if (v1 is Motorcycle m1 && v2 is Motorcycle m2)
            {
                Console.WriteLine("Both are motorcycles!");
            }

            Console.WriteLine();
        }
    }
}
