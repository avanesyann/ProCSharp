namespace ShapeDrawing
{
    class Rectangle : Shape
    {
        public Rectangle(string color) : base(color) { }
        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"Your shape is a {Color} rectangle.");
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
