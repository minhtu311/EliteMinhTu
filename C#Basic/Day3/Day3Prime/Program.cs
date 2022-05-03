using System;
using System.Threading.Tasks;

namespace Day3Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPrimeNumbersAsync(0, 100);
            GetPrimeNumbersSync(0, 100);
        }

        public static void GetPrimeNumbersSync(int minimum, int maximum)
        {
            for (int i = minimum; i <= maximum; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine("Sync: " + i);
                    Task.Delay(100).Wait();
                }
            }
        }

        public static async void GetPrimeNumbersAsync(int minimum, int maximum)
        {
            await Task.Run(() =>
            {
                for (int i = minimum; i <= maximum; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        Console.WriteLine("Async: " + i);
                        Task.Delay(100).Wait();
                    }
                }
            });
        }

        static bool IsPrimeNumber(int number)
        {
            if (number % 2 == 0)
            {
                return number == 2;
            }
            else
            {
                var topLimit = (int)Math.Sqrt(number);

                for (int i = 3; i <= topLimit; i += 2)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }
        }
    }
}
