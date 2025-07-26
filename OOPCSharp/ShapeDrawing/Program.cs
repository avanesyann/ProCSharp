namespace ShapeDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle("Yellow");
            c1.Describe();
            c1.Radius = 8;
            Console.WriteLine();
            Console.WriteLine("Area: {0:F2}", c1.GetArea());
            Console.WriteLine();

            Rectangle r1 = new Rectangle("Black");
            r1.Describe();
            Console.WriteLine();
            r1.Width = 20;
            r1.Height = 10;
            Console.WriteLine("Area: {0:F2}", r1.GetArea());
            Console.WriteLine();

            Circle c2 = new Circle("Teal");
            c2.Radius = 4;
            c2.Describe();

            Shape[] myShapes = {new Circle("Brown"), new Rectangle("Purple"), new Circle("Green"), new Rectangle("Blue")};

            foreach (Shape s in myShapes)
            {
                s.Describe();
            }

            // Method Shadowing

            // This calls the draw method of the ThreeDCircle.
            ThreeDCircle o = new ThreeDCircle("Black");
            o.Draw();

            // This calls the draw method of the parent.
            ((Circle)o).Draw();
        }
    }
}
