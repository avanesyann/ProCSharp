namespace VehicleRental
{
    public class Car : Vehicle
    {
        public int SeatCount { get; init; }

        public Car(int seatCount)
        {
            SeatCount = seatCount;
        }
        public override double CalculateRentalPrice(int hours)
        {
            throw new NotImplementedException();
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Has {0} seats.", SeatCount);
        }
    }
}
