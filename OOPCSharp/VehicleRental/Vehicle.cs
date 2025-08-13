namespace VehicleRental
{
    public abstract class Vehicle
    {
        public string Brand { get; init; }
        public string Model { get; init; }
        public bool IsAvailable { get; set; } = true;

        public abstract double CalculateRentalPrice(int hours);
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand} | Model: {Model}");
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Vehicle vehicle))
                return false;

            if (vehicle.Model == this.Model
                && vehicle.Brand == this.Brand)
                return true;

            return false;
        }
    }
}
