using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Chapter_3_OperatorsAndExpressions.Problem14
{
    class Problem_14:Problem
    {
        public override void Run()
        {
            try
            {
                int number = EnterTheNumber();

                bool isPrime = IsPrime(number);

                PrintTheResult(number, isPrime);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void PrintTheResult(int number, bool isPrime)
        {
            Writer.WriteLine(isPrime ? $"Number {number} is prime" : $"Number {number} is not prime");
        }

        private int EnterTheNumber()
        {
            Writer.WriteLine("Please enter the number you want to check:");
            return int.Parse(Reader.ReadLine());
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
