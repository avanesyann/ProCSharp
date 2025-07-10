namespace BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            Car myCar = new Car(80) { Speed = 50 };
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
        }
    }
}
