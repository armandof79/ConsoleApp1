using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE_page66
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number to multiply by 50");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = x * 50;
            Console.WriteLine(x + " times 50 is: " + result);
            Console.WriteLine("Enter a number to add to 25");
            int y = Convert.ToInt32(Console.ReadLine());
            int result2 = y + 25;
            Console.WriteLine(y + " plus 25 is: " + result2);
            Console.WriteLine("Please enter a number to divide by 12.5");
            decimal z = Convert.ToDecimal(Console.ReadLine());
            decimal result3 = z / 12.5m;
            Console.WriteLine(z + " divided by 12.5 is: " + result3);
            Console.WriteLine("Please enter a number to check if it's greater than 50");
            int a = Convert.ToInt32(Console.ReadLine());
            bool result4 = a > 50;
            Console.WriteLine("Is " + a + " greater than 50?: " + result4);
            Console.WriteLine("Please enter a number to see the remainder when divided by 7");
            int b = Convert.ToInt32(Console.ReadLine());
            int result5 = b % 7;
            Console.WriteLine("When " + b + " is divided by 7, the remainder is: " + result5);
            Console.Read();
        }
    }
}
