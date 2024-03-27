namespace MegaApplication
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double length, double width)
        {
            Width = width;
            Length = length;
            Name = "Rectangle";
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("It has a length of {0} and a width of {1}.", Length, Width);
        }
    }
}
