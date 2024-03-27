using System.Collections;

namespace MegaApplication
{
    class LinqStuff
    {
        #region Forwards
        public static void GetPlayers(string position)
        {
            Dictionary<string, string> squad_players = new()
            {
                { "Diogo Dalot", "fullback" },
                { "Rasmus Holjlund", "forward" },
                { "Paul Pogba", "midfielder" },
                { "Alejandro Garnacho Feyreyra", "forward" },
                { "Raphael Varane","defender" },
                { "Kobbie Mainoo", "midfielder" },
                { "Andre Onana", "goalkeeper" }
            };

            IEnumerable<string> players = from player in squad_players
                                          where player.Value == position.ToLower()
                                          select player.Key;

            foreach (string player in players)
            {
                // if (players)
                Console.WriteLine($"{position} player: {player}");
            }
        }
        #endregion

        #region Numbers
        public static int[] GetNumbers()
        {
            int[] numbers = { 10, 17, 32, 42, 23, 11, 8, 19, 74 };

            var gt20 = from number in numbers
                       where number > 20
                       orderby number ascending
                       select number;

            foreach (var number in gt20) Console.WriteLine(number);

            return gt20.ToArray();
        }
        #endregion

        #region AnimalFarm
        public static void GetAnimals()
        {
            Animal[] dogs = new[]
            {
                new Animal {
                    Name = "Chihuahua",
                    Weight = 34,
                    Height = 30,
                    AnimalID = 2,
                },
                new Animal {
                    Name = "Sting",
                    Weight = 34,
                    Height = 30,
                    AnimalID = 1,
                },
                new Animal {
                    Name = "Scooby",
                    Weight = 40,
                    Height = 48,
                    AnimalID = 2,
                },
                new Animal {
                    Name = "Dobberman",
                    Weight = 40,
                    Height = 48,
                    AnimalID = 2,
                },
                new Animal {
                    Name = "Broer",
                    Weight = 40,
                    Height = 48,
                    AnimalID = 1,
                },
            };

            #region dogs query
            var dog_list = dogs.OfType<Animal>();

            var get_dogs = from dog in dogs
                           where dog.Weight <= 40
                           orderby dog.Name descending
                           // select dog;
                           select new { dog.Name, dog.Height }; // get just the dog's name and height

            Array dogs_array = get_dogs.ToArray();
            #endregion

            Owner[] owners = new[]
            {
                new Owner { OwnerID = 1, Name = "Harry Winks", },
                new Owner { OwnerID = 2, Name = "Sally Stone", },
            };

            var innerjoin =
                        from dog in dogs
                        join owner in owners
                        on dog.AnimalID equals owner.OwnerID
                        select new { OwnerName = owner.Name, DogName = dog.Name };

            var groupjoin =
                        from owner in owners
                        orderby owner.OwnerID
                        join dog in dogs on owner.OwnerID
                        equals dog.AnimalID into ownerGroup
                        select new
                        {
                            Owner = owner.Name,
                            Dog =
                                from newowner in ownerGroup
                                orderby newowner.Name
                                select newowner
                        };

            foreach (var i in innerjoin)
            {
                Console.WriteLine("{0} owns {1}.", i.OwnerName, i.DogName);
            }

            Console.WriteLine();

            foreach (var ownergroup in groupjoin)
            {
                Console.WriteLine(ownergroup.Owner);
                foreach (var dog in ownergroup.Dog)
                {
                    Console.WriteLine("* {0}", dog.Name);
                }
            }
        }
        #endregion
    }
}
