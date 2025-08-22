namespace VehicleRental
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public double PriceAnHour { get; set; } = 170;

        public override double CalculateRentalPrice(int hours)
        {
            return PriceAnHour * hours;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{(HasSidecar ? "Has" : "Doesn't have")} a sidecar.");
        }
    }
}
