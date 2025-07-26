namespace ShapeDrawing
{
    class Circle : Shape
    {
        public double Radius { get; set; }
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
        public override double GetArea()
        {
            if (Radius <= 0)
            {
                Console.WriteLine("The radius of the circle is not set.");
                return 0;
            }
            else
            {
                return Math.PI * Radius * Radius;
            }
        }
    }

    class ThreeDCircle : Circle
    {
        public ThreeDCircle(string color) : base(color) { }

        // Hide any Draw() implementation above me
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D circle.");
        }
    }
}
