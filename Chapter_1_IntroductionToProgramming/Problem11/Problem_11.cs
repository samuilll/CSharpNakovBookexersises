using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Chapter_1_IntroductionToProgramming.Problem11
{
    class Problem_11:Problem
    {
        public override void Run()
        {
            try
            {
                Writer.WriteLine("Please enter your current age:");
                int currentAge = int.Parse(Reader.ReadLine());

                int calculatedAge = currentAge + 10;

                Writer.WriteLine($"After 10 years you will be {calculatedAge} years old");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
