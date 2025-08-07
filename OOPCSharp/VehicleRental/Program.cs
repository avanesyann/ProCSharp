namespace VehicleRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car(4) { Brand = "Porsche", Model = "911" });

            vehicles.Add(new Car(4) { Brand = "Porsche", Model = "Taycan" });

            vehicles.Add(new Motorcycle(false) { Brand = "Harley-Davidson", Model = "Sportster" });

            vehicles.Add(new Bicycle(true) { Brand = "Trek", Model = "Marlin" });

            vehicles.Add(new Car(2) { Brand = "Porsche", Model = "911 Carrera S" });

            foreach (Vehicle vehicle in vehicles)
            {
                Car car = vehicle as Car;
                if (car == null)
                {
                    Console.WriteLine("That's not a car.");
                }
                else
                {
                    car.DisplayInfo();
                    Console.WriteLine($"Are {vehicles[0].Model} and {vehicle.Model} the same?: {(vehicles[0].Equals(vehicle) ? "Yes!" : "Nope")}");
                }

                
                Console.WriteLine();
            }
        }
    }
}
