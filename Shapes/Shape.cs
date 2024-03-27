namespace MegaApplication
{
    abstract class Shape
    {
        public string? Name { get; set; }

        public abstract double GetArea();

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}.");
        }
    }
}
