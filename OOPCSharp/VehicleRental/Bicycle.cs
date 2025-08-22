namespace VehicleRental
{
    public class Bicycle : Vehicle
    {
        public bool IsElectric { get; set; }
        public double PriceAnHour { get; set; } = 20;

        public override double CalculateRentalPrice(int hours)
        {
            return PriceAnHour * hours;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Is {(IsElectric ? "Electric" : "Not Electric")}");
        }
    }
}
