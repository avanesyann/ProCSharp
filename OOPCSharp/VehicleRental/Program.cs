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
            rental.AddVehicle(new Car(2) { Brand = "Porsche", Model = "911 Turbo S" });
            rental.AddVehicle(new Van(true) { Brand = "Chevrolet", Model = "Vandura" });

            // todo: find all the vehicles by that model instead of just one.
            rental.RentVehicle("Sportster", 4);
            rental.RentVehicle("911", 1);
            rental.RentVehicle("Marlin", 4);

            rental.CompareVehicles(rental.FindByModel("911 Carrera S"), rental.FindByModel("911"));
            rental.CompareVehicles(rental.FindByModel("911 Turbo S"), rental.FindByModel("911"));

            rental.FindByModel("911").DisplayInfo();
            rental.FindByModel("911 Turbo S").DisplayInfo();
            rental.FindByModel("911 Carrera S").DisplayInfo();
            Console.WriteLine();

            rental.ReturnVehicle("911 Turbo S");
            rental.ReturnVehicle("Marlin");
            rental.ReturnVehicle("911");
        }
    }
}
