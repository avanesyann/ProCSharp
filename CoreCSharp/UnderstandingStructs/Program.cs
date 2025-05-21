namespace UnderstandingStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            myPoint.Increment();
            myPoint.Display();
        }


    }
    struct Point
    {
        public int X;
        public int Y;

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
