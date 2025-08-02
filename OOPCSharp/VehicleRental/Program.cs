namespace VehicleRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car porsche = new Car(4) { Brand = "Porsche", Model = "911" };
            porsche.DisplayInfo();
        }
    }
}
