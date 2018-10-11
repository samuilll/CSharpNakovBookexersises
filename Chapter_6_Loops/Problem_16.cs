using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Chapter_6_Loops
{
     class Problem_16 : Problem
    {
        // Randomize members from 1 To N
        public override void Run()
        {
            Console.WriteLine("Please insert an integer number:");
            int num = int.Parse(Console.ReadLine());

            Random randomizer = new Random();

            List<int> list = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Your numbers rendomized:");
            while (list.Any())
            {
                int numToPrint = list[randomizer.Next(list.Count)];
                list.Remove(numToPrint);

                Console.Write($"{numToPrint} ");
            }
        }
    }
}
