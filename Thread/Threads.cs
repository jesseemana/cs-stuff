namespace MegaApplication
{
    class Threads
    {
        static void PrintOne()
        {
            for (int i = 1; i < 1000; i++)
            {
                Console.Write(1);
            }
        }

        static void Count(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Counter()
        {
            Thread t = new(() => Count(10));
            t.Start();

            new Thread(() =>
            {
                Count(7);
                Count(14);
            }).Start();
        }

        public static void StartThread()
        {
            Thread t = new(PrintOne);
            t.Start();
            
            for (int i = 1; i < 1000; i++)
            {
                Console.Write(0);
            }
        }

        public static void Delayed()
        {
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Thread ends.");
        }
    }
}
