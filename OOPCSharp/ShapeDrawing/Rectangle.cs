namespace ShapeDrawing
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

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
            if (Width <= 0 || Height <= 0)
            {
                Console.WriteLine("The size of the rectangle is not set.");
                return 0;
            }
            else
            {
                return Width * Height;
            }
        }
    }
}
