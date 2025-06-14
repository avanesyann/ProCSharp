namespace ClassType
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaawww!");
            }
        }
        public void SetDriverName(string name)
        {
            driverName = name;
        }

        //public Motorcycle()
        //{ 
        //    Console.WriteLine("In default constructor"); 
        //}
        //public Motorcycle(int intensity) : this(intensity, "")
        //{
        //    Console.WriteLine("In constructor taking an int");
        //}
        //public Motorcycle(string name) : this(0, name)
        //{
        //    Console.WriteLine("In constructor taking a string");
        //}
        //public Motorcycle(int intensity, string name)
        //{
        //    Console.WriteLine("In main constructor");
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverName = name;
        //    driverIntensity = intensity;
        //}

        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
