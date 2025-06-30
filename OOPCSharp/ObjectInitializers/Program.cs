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

            Point pt = new Point(10, 20) { X = 100, Y = 100 };
            pt.DisplayStats();
            Console.WriteLine();

            Console.WriteLine();

            Point goldPoint = new Point(PointColorEnum.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();

            Point gPoint = new Point() { X = 160, Y = 60 };
            gPoint.DisplayStats();

            Console.WriteLine();

            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            myRect.DisplayStats();

            // Old-school approach.
            //Rectangle r = new Rectangle();
            //Point p1 = new Point();
            //p1.X = 10;
            //p1.Y = 10;
            //r.TopLeft = p1;
            //Point p2 = new Point();
            //p2.X = 200;
            //p2.Y = 200;
            //r.BottomRight = p2;
        }
    }
}
