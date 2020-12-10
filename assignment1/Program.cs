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

            Console.WriteLine("Enter a price: ");
            float input = float.Parse(Console.ReadLine());

            float originalprice = Price(input);

            float taxes = vat(input);

            float totalprice = totalPrice(input);

            Console.WriteLine($"price: {originalprice.ToString("0.00")}, vat: {taxes.ToString("0.00")}, total: {totalprice.ToString("0.00")}");
            Console.ReadKey();
        }

        static float Price(float num1)
        {
            float price = num1;
            return price;
        }

        static float vat(float num1)
        {
            float vat = (num1 / 100) * 21;
            return vat;
        }

        static float totalPrice(float num1)
        {
            float vat = (num1 / 100) * 21;
            float total = num1 + vat;
            return total;
        }
    }
}

