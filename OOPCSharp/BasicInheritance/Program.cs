namespace BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            Car myCar = new Car(80) { Speed = 50 };
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
            Console.WriteLine();

            MiniVan myVan = new MiniVan { Speed = 10 };
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);
            myVan.Speed = 55;
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);
            myVan.HasSlidingDoor = false;
            Console.WriteLine();


        }
    }
}
