namespace VehicleRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalManager rental = new RentalManager();
            rental.AddVehicle(new Car(4) { Brand = "Porsche", Model = "911" });
            rental.AddVehicle(new Car(4) { Brand = "Porsche", Model = "Taycan" });
            rental.AddVehicle(new Motorcycle(false) { Brand = "Harley-Davidson", Model = "Sportster" });
            rental.AddVehicle(new Bicycle(true) { Brand = "Trek", Model = "Marlin" });
            rental.AddVehicle(new Car(2) { Brand = "Porsche", Model = "911 Carrera S" });

            // todo: find all the vehicles by that model instead of just one.
            rental.RentVehicle("911", 24);
            rental.RentVehicle("Sportster", 4);
            rental.RentVehicle("911", 1);
            rental.RentVehicle("Marlin", 4);
        }
    }
}
