namespace VehicleRental
{
    public class Bicycle : Vehicle
    {
        public bool IsElectric { get; set; }

        public override double CalculateRentalPrice(int hours)
        {
            throw new NotImplementedException();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Is {(IsElectric ? "Electric" : "Not Electric")}");
        }
    }
}
