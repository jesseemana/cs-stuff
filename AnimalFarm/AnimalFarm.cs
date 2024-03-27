using System.Collections;

namespace MegaApplication
{
    class AnimalFarm : IEnumerable
    {
        private readonly List<Animal> animal_list = new();

        public AnimalFarm(List<Animal> animals) { animal_list = animals; }

        public AnimalFarm() { }

        public Animal this[int index]
        {
            get => animal_list[index];
            set => animal_list.Insert(index, value);
        }

        public IEnumerator GetEnumerator() // will let us iterate through our animal list
        {
            return animal_list.GetEnumerator();
        }
    }
}
