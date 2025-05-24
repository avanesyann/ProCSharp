namespace UnderstandingStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point myPoint;      // = new Point(); assigns default values (e.g. 0)
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            myPoint.Increment();
            myPoint.Display();

            Console.WriteLine();

            Point secondPoint = new Point(50, 50);
            secondPoint.Display();

            Console.WriteLine();

            Point thirdPoint = new Point();
            thirdPoint.Display();

            Console.WriteLine();

            var s = new DisposableRefStruct(50, 60);
            s.Display();
            s.Dispose();
        }


    }
    struct Point
    {
        public int X;
        public int Y;

        public Point()
        {
            X = 1;
            Y = 1;
        }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public void Increment()
        {
            X++; Y++;
        }
        public void Decrement()
        {
            X--; Y--;
        }
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    readonly struct ReadOnlyPoint
    {
        public int X { get; }
        public int Y { get; }

        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public ReadOnlyPoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
    }

    ref struct DisposableRefStruct
    {
        public int X;
        public readonly int Y;
        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
        public DisposableRefStruct(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
            Console.WriteLine("Created!");
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed!");
        }
    }
}
