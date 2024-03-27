namespace MegaApplication
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("It has a radius of {0}.", Radius);
        }
    }
}
