using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_QuoteApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please the package weight:");
            string packageWeight = Console.ReadLine();
            int pacWei = Convert.ToInt32(packageWeight);
            Console.ReadLine();

            Console.WriteLine("Please the package width:");
            string packageWidth = Console.ReadLine();
            int pacWid = Convert.ToInt32(packageWidth);
            Console.ReadLine();

            Console.WriteLine("Please the package height:");
            string packageHeight = Console.ReadLine();
            int pacHei = Convert.ToInt32(packageHeight);
            Console.ReadLine();

            Console.WriteLine("Please the package length:");
            string packageLength = Console.ReadLine();
            int pacLen = Convert.ToInt32(packageLength);
            Console.ReadLine();

            int total = pacWid + pacHei + pacLen;
            int total2 = pacHei * pacWid * pacLen;
            int total3 = total2 * pacWei / 100;


            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is £" + total3);
            }
            Console.ReadLine();

            Console.WriteLine("Thank You.");
            Console.ReadLine();

        }
    }
}
