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
}
