namespace AutoProps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.PetName = "Jerry";
            c.Speed = 55;
            c.Color = "Brown";

            c.DisplayStats();

            Console.WriteLine();

            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number of cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);
        }
    }
}
