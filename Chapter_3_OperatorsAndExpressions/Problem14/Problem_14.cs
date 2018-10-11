using System;
using Utilities;

namespace Chapter_3_OperatorsAndExpressions.Problem14
{
    class Problem_14:Problem
    {
        public override void Run()
        {

                int number = EnterTheNumber();

                bool isPrime = IsPrime(number);

                PrintTheResult(number, isPrime);
        }

        private void PrintTheResult(int number, bool isPrime)
        {
            Writer.WriteLine(isPrime ? $"Number {number} is prime" : $"Number {number} is not prime");
        }

        private int EnterTheNumber()
        {
            Writer.WriteLine("Please enter the number you want to check (prime or not prime):");
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
