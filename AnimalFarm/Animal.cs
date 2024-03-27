namespace MegaApplication
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        public Animal() : this("name", 1, 1) { }
        
        public Animal(string name = "No Name", double weight = 0, double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public static string GetHealth()
        {
            Animal animal = new();
            if ((animal.Weight / animal.Height) < 200.0)
                return "Animal is healthy.";
            else return "Animal is unhealthy.";
        }

        public override string ToString()
        {
            return $"{Name} weighs {Weight}kg and is {Height}cm tall. {GetHealth()}";
        }
    }
}
