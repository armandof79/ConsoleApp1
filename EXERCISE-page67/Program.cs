using System;


namespace EXERCISE_page67
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal person1 = a * b;

            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate");
            decimal c = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            decimal person2 = c * d;
            bool compareSalary = person1 > person2;
            Console.WriteLine("Does Person #1 make more money than Person #2? " + compareSalary);
            Console.Read();

        }
    }
}
