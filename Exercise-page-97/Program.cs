using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_page_97
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "con";
            string b = "cat";
            string c = "e";
            string d = "nate";
            string e = a + b + c + d;
            Console.WriteLine(e);
            Console.WriteLine(e.ToUpper());

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("Humpty Dumpty sat on a wall,\n");
            Console.WriteLine(paragraph);
            paragraph.Append("Humpty DumpHumpty Dumpty had a great fall;\n");
            Console.WriteLine(paragraph);
            paragraph.Append("All the king's horses and all the king's men\n");
            Console.WriteLine(paragraph);
            paragraph.Append("Couldn't put Humpty together again.");
            Console.WriteLine(paragraph);
            Console.ReadLine();


        }
    }
}
