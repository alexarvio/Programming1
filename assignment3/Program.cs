using System;
using System.Globalization;
using System.Threading;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            while(year != 0)
            {
                if (year < 0)
                    Console.WriteLine("Negative year entered...");
                if (IsLeapYear(year))
                    Console.WriteLine($"{year} is a leap year.");
                else
                    Console.WriteLine($"{year} is not a leap year");
            }

            Console.ReadKey();
        }

        static bool IsLeapYear(int year)
        {
            if (year < 0)
            {
                return false;
            }

            bool fourhundred = ((year % 400) == 0);
            bool hundred = ((year % 100) == 0);
            bool four = ((year % 4) == 0);

            return (fourhundred || (four && !hundred));


        }
    }
}
