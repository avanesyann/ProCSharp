namespace ClassType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car porsche = new Car("Porsche", 80);
            Car amg = new Car("AMG", 40);
            Car lambo = new Car("Lambo", 120, out bool inDanger);

            for (int i = 0; i < 10; i++)
            {
                porsche.SpeedUp(5);
                porsche.PrintState();
            }

            amg.PrintState();
            
            lambo.PrintState();

            Console.WriteLine();
            Console.WriteLine();

            Motorcycle mc = new Motorcycle(2);
            Motorcycle mcNoCtor = new Motorcycle();
            mc.PopAWheely();
        }
    }
}
