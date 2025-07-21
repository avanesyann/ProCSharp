namespace ShapeDrawing
{
    class Circle : Shape
    {
        public Circle(string color) : base(color) { }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"Your shape is a {Color} circle.");
        }
    }
}
