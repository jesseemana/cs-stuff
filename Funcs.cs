namespace MegaApplication
{
    class Funcs
    {
        public Funcs() {}

        public static void DoubleNum(int x, out int solution)
        {
            solution = x * 2;
        }
        // Funcs.DoubleNum(97, out int solution);
        // Console.WriteLine("97 * 2 = {0}", solution);

        public static bool IsEven(int number) 
        {
            return number % 2 == 0;
        }

        public static double GetSumMore(params double[] numbers)
        {
            double sum = 0;
            foreach (double i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        public static void BirthdayDetails()
        {
            DateTime birth_day = new(1997, 07, 30);
            var day_of_birth = birth_day.DayOfWeek;
            var year_of_birth = birth_day.Year;
            Console.WriteLine("I was born on a cold {0} night, sometime in {1}.", day_of_birth, year_of_birth);
        }
    }
}
