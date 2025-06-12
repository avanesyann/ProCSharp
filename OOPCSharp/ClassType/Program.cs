namespace ClassType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "BMW";
        }
    }
    class Car
    {
        public string Name;
        public int Speed;
    }
}
