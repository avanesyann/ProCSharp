namespace ShapeDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle("Yellow");
            c1.Describe();

            Rectangle r1 = new Rectangle("Black");
            r1.Describe();
        }
    }
}
