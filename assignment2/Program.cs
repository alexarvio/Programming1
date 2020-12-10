using System;
using System.Globalization;
using System.Threading;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            

            Console.WriteLine("Enter a number (0 is stop value): ");
            int input = Int32.Parse(Console.ReadLine());

            while(input != 0)
            {
                if (IsPrimeNumber(input))
                {
                    Console.WriteLine($"{input} is a prime number.");
                }
                if (input < 0)
                {
                    Console.WriteLine("Negative numeber entered...");
                }
                else
                {
                    Console.WriteLine($"{input} is not a prime number.");
                }

            }

            static bool IsPrimeNumber(int number)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                    return true;
                }
            }
        }

        
    }
}
