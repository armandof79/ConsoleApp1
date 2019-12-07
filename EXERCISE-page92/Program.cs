using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE_page92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What's Your package weight?");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("What's Your package width?");
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What's Your package height?");
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What's Your package length?");
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());
            decimal dimensions = packageWidth + packageHeight + packageLength;

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            else
            {
                decimal cost = dimensions * packageWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: " + cost);

            }

            Console.ReadLine();

        }
    }
}
