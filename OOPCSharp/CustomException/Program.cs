namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Custom Exception *****");

            Car myCar = new Car("Rusty", 90);

            try
            {
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
        }
    }
}
