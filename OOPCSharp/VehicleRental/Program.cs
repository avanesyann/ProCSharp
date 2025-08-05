namespace VehicleRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car porsche = new Car(4) { Brand = "Porsche", Model = "911" };
            porsche.DisplayInfo();
            Console.WriteLine();

            Car porsche2 = new Car(4) { Brand = "Porsche", Model = "Taycan" };

            Motorcycle harley = new Motorcycle(false) { Brand = "Harley-Davidson", Model = "Sportster" };
            harley.DisplayInfo();
            Console.WriteLine();

            Bicycle trek = new Bicycle(true) { Brand = "Trek", Model = "Marlin" };
            trek.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine($"Are the Porsches the same?: {(porsche.Equals(porsche2) ? "Yes!" : "Nope")}");
        }
    }
}
