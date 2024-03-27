namespace MegaApplication
{
    public struct Recipe
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Image { get; set; }
        public int Time_To_Prepare { get; set; }
        public string[] Ingridients { get; set; }
        public string How_To_Prepare { get; set; }

        public override readonly string ToString()
        {
            return $"Here's how you prepare a {Name}, {How_To_Prepare} It takes {Time_To_Prepare} minutes to prepare.";
        }
    }
}
