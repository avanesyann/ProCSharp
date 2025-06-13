namespace ClassType
{
    class Motorcycle
    {
        public int driverIntensity;
        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaawww!");
            }
        }

        public Motorcycle() { }
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }
}
