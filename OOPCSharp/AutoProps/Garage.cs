namespace AutoProps
{
    class Garage
    {
        // The hidden int backing field is set to zero.
        public int NumberOfCars { get; set; } = 1;

        // The hidden Car backing field is set to null.
        public Car? MyAuto { get; set; } = new Car();

        public Garage()
        {
            // MyAuto = new Car();      // No need, since it's already initialized.
            // NumberOfCars = 1;        // ...
        }
        public Garage(Car car, int numberOfCars)
        {
            MyAuto = car;
            NumberOfCars = numberOfCars;
        }
    }
}
