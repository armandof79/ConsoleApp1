﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE_page94
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 20)
            {
                Console.WriteLine(i);
                i ++;
            }
            int x = 0;
            do
            {               
                Console.WriteLine(x);
                x ++;
            }
            while (x < 20);
            Console.ReadLine();

        }
    }
}
