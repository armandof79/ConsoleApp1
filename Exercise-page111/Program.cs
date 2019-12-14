using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_page111
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 d = new TestClass1();
            Console.WriteLine("Please enter a number to divide by 2");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(d.Divider(input1));


            TestClass1 m = new TestClass1();
            Console.WriteLine("Please enter a number to multiply by 2");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m.Multiplier(input2));

            TestClass1 a = new TestClass1();
            Console.WriteLine("Please enter a number to add to 2");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a.Adder(input3));
            Console.ReadLine();

        }
    }
}
