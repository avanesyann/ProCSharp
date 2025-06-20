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

            //Console.WriteLine("Motorcycle 1");
            //Motorcycle miny = new Motorcycle(5);
            //miny.SetDriverName("Miny");
            //miny.PopAWheely();
            //Console.WriteLine("Rider name is {0}", miny.driverName);

            //Console.WriteLine();

            //Console.WriteLine("Motorcycle 2");
            //Motorcycle tiny = new Motorcycle("Tiny");
            //tiny.PopAWheely();
            //Console.WriteLine("Rider name is {0}", tiny.driverName);

            //Console.WriteLine();

            //Console.WriteLine("Motorcycle 3");
            //Motorcycle shiny = new Motorcycle(10, "Shiny");
            //tiny.PopAWheely();
            //Console.WriteLine("Rider name is {0}", tiny.driverName);

            MakeSomeBikes();

            Console.WriteLine();
            Console.WriteLine();

            // Static Data And Members

            Console.WriteLine("Static Data And Members");
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);

            Console.WriteLine("Balance: {0}, Interest Rate: {1}", s1.currBalance, SavingsAccount.InterestRate);
            Console.WriteLine("Balance: {0}, Interest Rate: {1}", s2.currBalance, SavingsAccount.InterestRate);

            SavingsAccount.InterestRate = 0.08;

            SavingsAccount s3 = new SavingsAccount(10000.75);

            Console.WriteLine("Balance: {0}, Interest Rate: {1}", s3.currBalance, SavingsAccount.InterestRate);

            Console.WriteLine();

            TimeUtilClass.PrintTime();
            TimeUtilClass.PrintDate();
        }
        static void MakeSomeBikes()
        {
            Motorcycle m1 = new Motorcycle();
            Console.WriteLine("Name = {0}, Intensity = {1}", m1.driverName, m1.driverIntensity);

            Motorcycle m2 = new Motorcycle(name: "Tiny");
            Console.WriteLine("Name = {0}, Intensity = {1}", m2.driverName, m2.driverIntensity);


            Motorcycle m3 = new Motorcycle(7);
            Console.WriteLine("Name = {0}, Intensity = {1}", m3.driverName, m3.driverIntensity);
        }
    }
}
