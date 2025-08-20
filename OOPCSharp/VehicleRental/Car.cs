namespace VehicleRental
{
    public class Car : Vehicle
    {
        public int SeatCount { get; init; }
        public double PriceAnHour { get; set; } = 100;

        public Car(int seatCount)
        {
            SeatCount = seatCount;
        }
        public override double CalculateRentalPrice(int hours)
        {
            return hours * PriceAnHour;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Has {0} seats.", SeatCount);
        }
    }
}
