namespace VehicleRental
{
    public class Van : Vehicle
    {
        public bool DoorSlides { get; set; }
        public double PriceAnHour { get; set; } = 150;

        public override double CalculateRentalPrice(int hours)
        {
            return hours * PriceAnHour;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{(DoorSlides ? "Has" : "Doesn't have")} sliding side doors.");
        }
    }
}
