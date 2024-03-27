using System;

namespace MegaApplication
{
    public class StartApp
    {
        public static void Main(string[] args)
        {

            #region Shapes
            // Shape[] shapes = { new Circle(4), new Rectangle(4.39, 8.7) };
            // foreach (Shape shape in shapes)
            // {
            //     shape.GetInfo();
            //     Console.WriteLine("{0} Area: {1:f3}.", shape.Name, shape.GetArea());
            //     if (shape is not Circle) { Console.WriteLine("This isn't a circle."); }
            //     if (shape is Circle) { Console.WriteLine("This isn't a rectangle.\n"); }
            // }
            #endregion

            // dblIt dbl = x => x * 2;
            // Console.WriteLine(dbl(24));

            #region Box
            // Box box1 = new(4.7, 2.7, 1.4);
            // Box box2 = new(2.8, 9.83, 37.3);
            // Box new_box1 = box1 + box2;
            // Box new_box2 = box1 * box2;
            // Console.WriteLine("New box {0}", new_box2.ToString());
            #endregion

            LinqStuff.GetAnimals();
            
        }

        delegate double dblIt(double val);

        #region Higher Order Functions(Lambdas)
        // Other Higher Order Functinons
        // var array1 = new int[] { 1, 2, 3, 4 };
        // var array2 = new int[] { 2, 7, 4, 9 };
        // array1.Any(x => x > 3) returns boolean if any item matches
        // array2.All(x => x > 3) returns boolean if every item matches
        // array1.Distinct(array2) return unique values => 1, 3, 7, 9
        // array1.Except(array2) returns values not in passed list => 1, 3
        // array1.Intersect(array2) return values in both lists
        static int Summarize(params int[] numbers)
        {
            return numbers.Aggregate((a, b) => a + b);
        }
        static void Average(params int[] numbers)
        {
            Console.WriteLine("Total for our numbers is: {0}", numbers.AsQueryable().Average());
        }

        static int[] Transform(params int[] numbers)
        {
            return numbers.Select(x => x * 2).ToArray();
        }

        static List<int> Evens(params int[] numbers)
        {
            return numbers.Where(a => a % 2 == 0).ToList();
        }
        #endregion
    }
}
