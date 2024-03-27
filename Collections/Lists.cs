using System.Collections;
using System.Collections.Generic;

namespace MegaApplication
{
    class Collections
    {
        #region ArraryList
        public static void ArrayList()
        {
            ArrayList aList = new()
            {
                "John Doe",
                42,
                true
            };

            Console.WriteLine("Count for first list is {0}", aList.Count);
            Console.WriteLine("Capacity for first list is {0}", aList.Capacity);

            ArrayList aList2 = new();
            aList2.AddRange(new object[] { "beans", "eggs", "rice" });
            aList.AddRange(aList2);
        }
        #endregion

        #region Dictionaries
        public static void Squad()
        {
            Dictionary<string, string> players = new()
            {
                { "Marcus Rashford", "Forward" },
                { "Diogo Dalot", "Fullback" },
                { "Kobbie Mainoo", "Midfielder" },
            };

            Console.WriteLine("Does our squad have Mbappe?: {0}", players.ContainsKey("Kylian Mbappe"));
            players.Remove("Marcus Rashford");
            players.TryGetValue("Kobbie Mainoo", out string? baller);
            Console.WriteLine("Rising baller number one: {0}\n", baller);

            players.Add("Bruno Fernandes", "CAM");
            players.Add("Lisandro Martinez", "Defender");
            players.Add("Raphael Varane", "Defender");

            Console.WriteLine("Our current squad");
            foreach (KeyValuePair<string, string> player in players)
                Console.WriteLine("{0}: {1}", player.Key, player.Value);
        }
        #endregion
    }
}
