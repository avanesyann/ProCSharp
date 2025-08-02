namespace VehicleRental
{
    public abstract class Vehicle
    {
        public string Brand { get; init; }
        public string Model { get; init; }

        public abstract double CalculateRentalPrice(int hours);
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand} | Model: {Model}");
        }
    }
}
