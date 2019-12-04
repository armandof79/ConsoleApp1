using System;


namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string question1 = Console.ReadLine();
            Console.WriteLine("What page number?");
            int question2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool question3 =  Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string questionn4 = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string questionn5 = Console.ReadLine();
            Console.WriteLine("How many hours did you study today ?"); 
            int question6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
