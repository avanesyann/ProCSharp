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

        static void MakeACar()
        {
            // when you assign object references to null, the compiler creates
            // CIL code that ensures the reference no longer points to any object
            Car myCar = new Car();
            myCar = null;
        }
    }
}
