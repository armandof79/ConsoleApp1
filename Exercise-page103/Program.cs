using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_page103
{
    class Program
    {
        static void Main(string[] args)
        {
        //    List<String> info = new List<string>();
        //    Console.WriteLine("Please enter you name");
        //    info.Add(Console.ReadLine());
        //    Console.WriteLine("What is your favorite color?");
        //    info.Add(Console.ReadLine());
        //    Console.WriteLine("What is your favorite ice cream flavor?");
        //    info.Add(Console.ReadLine());
        //    String[] aboutMe = { "my name is ", "my favotite color is ", "and my favorite ice cream flavor is " };
        //    for (int i = 0; i < aboutMe.Length; i++)
        //    {
        //        string temp = aboutMe[i] + info[i];
        //        Console.WriteLine(temp);
        //    }

        //    //-------------INFINITE LOOP-----------------------

        //    //for (int count = 0; count < 0; count--)
        //    //{
        //    //    Console.WriteLine(count);
        //    //}

        //    for (int count = 0; count < 10; count++)
        //    {
        //        Console.WriteLine(count);
        //    }

        //    for (int count = 0; count < 20; count++)
        //    {
        //        Console.WriteLine(count);
        //    }

        //    for (int count = 0; count <= 10; count++)
        //    {
        //        Console.WriteLine(count);
        //    }

        //    List<string> rainbow = new List<string> { "red", "orange", "yellow", "green", "blue", "violet" };
        //searchagain:
        //    Console.WriteLine("Name one of the colors of the rainbow");
        //    string temp3 = Console.ReadLine();
        //    string search = temp3.ToLower();
        //    if (rainbow.IndexOf(search) < 0)
        //    {
        //        Console.WriteLine(search + " is not a color of the rainbow, therefor it is not an assigned value");
        //        goto searchagain;
        //    }
        //    else
        //    {
        //        foreach (string rainbowColor in rainbow)
        //        {
        //            if (rainbowColor == search)
        //            {
        //                Console.WriteLine("The value " + search + " is cointained in index " + rainbow.IndexOf(search));
        //            }
        //        }
        //   }

        //    List<string> farmAnimals = new List<string> { "cow", "chicken", "duck", "sheep", "shep" };
        //step:
        //    Console.WriteLine("Name a farm animal");
        //    string temp2 = Console.ReadLine();
        //    string search2 = temp2.ToLower();
        //    if (farmAnimals.IndexOf(search2) < 0)
        //    {
        //        Console.WriteLine("we do not have a " + search2 + " in this farm");
        //        goto step;
        //    }
        //    else
        //    {
        //        foreach (string animal in farmAnimals)
        //        {
        //            if (farmAnimals == search2)
        //            {
        //                Console.WriteLine("The value " + search2 + " is cointained in index " + farmAnimals.IndexOf(search2));
        //            }
        //        }



        //    }


            List<String> newList = new List<String> { "One", "Two", "Three", "Four", "Four" };
            foreach ( string numString in newList)
            {
                Console.WriteLine(newList.IndexOf(numString));
            }
            Console.ReadLine();
        }   
    }
}
