namespace ObjectInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set each property manually
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // via a custom constructor
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // object init syntax
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            Console.WriteLine();

            // Make readonly point after construction
            ReadOnlyPointAfterCreation firstReadonlyPoint = new ReadOnlyPointAfterCreation(20, 20);
            firstReadonlyPoint.DisplayStats();

            ReadOnlyPointAfterCreation secondReadonlyPoint = new ReadOnlyPointAfterCreation { X = 30, Y = 30 };
            secondReadonlyPoint.DisplayStats();

            Console.WriteLine();
        }
    }
}
