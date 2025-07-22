namespace ShapeDrawing
{
    abstract partial class Shape
    {
        public abstract void Draw();

        public virtual void Describe()
        {
            Console.WriteLine("You've created a shape.");
        }

        public abstract double GetArea();
    }
}
