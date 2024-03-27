namespace MegaApplication
{
    class Box
    {
        private double Width { get; set; }
        private double Length { get; set; }
        private double Breadth { get; set; }

        public Box() : this(1, 1, 1) { }

        public Box(double length, double width, double breadth)
        {
            Width = width;
            Length = length;
            Breadth = breadth;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box box = new()
            {
                Width = box1.Width + box2.Width,
                Length = box1.Length + box2.Length,
                Breadth = box1.Breadth + box2.Breadth
            };
            return box;
        }

        public static Box operator *(Box box1, Box box2)
        {
            Box box = new()
            {
                Width = box1.Width * box2.Width,
                Length = box1.Length * box2.Length,
                Breadth = box1.Breadth * box2.Breadth
            };
            return box;
        }

        public override string ToString()
        {
            return string.Format("has a length: {0}, width: {1}, and breadth {2}", Length, Width, Breadth);
        }
    }
}
