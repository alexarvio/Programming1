using System;
using System.Globalization;
using System.Threading;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

        }

        static void SearchText(string nrOfFullStops, string nrOfCommas, string nrOfSemiColons)
        {

        }
    }
}
