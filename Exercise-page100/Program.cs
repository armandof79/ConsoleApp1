using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_page100
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string[] locations = { "Italy", "France", "Germany", "Japan" };
        start:
            Console.WriteLine("Please enter a number from 0 to 3");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i > 3 || i < 0)
            {
                Console.WriteLine("The number must be no smaller than 0 and no larger than 3");
                goto start;
            }

            Console.WriteLine("You have entered " + i + ", you've won a trip to " + locations[i]);


            
            int[] nums = { 22, 34, 10, 7 };
        tryAgain:
            Console.WriteLine("Part 2: Please enter a number from 0 to 3");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 3 || a < 0)
            {
                Console.WriteLine("The number must be no smaller than 0 and no larger than 3");
                goto tryAgain;
            }
            Console.WriteLine("The value of index " + a + " is: " + nums[a]);



            List<String> zoo = new List<String>();
            zoo.Add("Lion");
            zoo.Add("Zebra");
            zoo.Add("Tiger");
            zoo.Add("Elephant");
         startOver:
            Console.WriteLine("Part 3: Please enter a number from 0 to 3");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b > 3 || b < 0)
            {
                Console.WriteLine("The number must be no smaller than 0 and no larger than 3");
                goto startOver;
            }

            Console.WriteLine("The value of index " + b + " is: " + zoo[b]);
            Console.ReadLine();

        }
    }
}
