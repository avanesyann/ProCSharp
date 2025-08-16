namespace VehicleRental
{
    public class Van : Vehicle
    {
        public bool DoorSlides { get; set; }

        public Van(bool doorSlides)
        {
            DoorSlides = doorSlides;
        }

        public override double CalculateRentalPrice(int hours)
        {
            throw new NotImplementedException();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{(DoorSlides ? "Has" : "Doesn't have")} sliding side doors.");
        }
    }
}
