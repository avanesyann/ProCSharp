namespace SimpleGC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new car object on the managed heap.
            // We are returned a reference to the object
            Car refToMyCar = new Car("Zippy", 50);

            // The C# dot operator is used to invoke members
            // on the object using our reference variable.
            Console.WriteLine(refToMyCar.ToString());
        }
    }
}
