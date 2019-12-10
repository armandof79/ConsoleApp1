using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_page106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int> { 32, 678, 93, 107 };
                Console.WriteLine("Please enter a number");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int number in intList)
                {
                    Console.WriteLine(number / userNumber);

                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.ReadLine();
            }
            
        }
    }
}
