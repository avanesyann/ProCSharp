namespace VehicleRental
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(bool hasSidecar)
        {
            HasSidecar = hasSidecar;
        }

        public override double CalculateRentalPrice(int hours)
        {
            throw new NotImplementedException();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{(HasSidecar ? "Has" : "Doesn't have")} a sidecar.");
        }
    }
}
