using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Chapter_3_OperatorsAndExpressions.Problem10
{
    class Problem_10:Problem
    {
        public override void Run()
        {
            try
            {
                int number = EnterTheNumber();

                ValidateCountOfNumberDigits(number);

                PrintSumOfTheDigits(number);
                PrintTheReversedNumber(number);
                PrintNumberWithFirstAndLastDigitsReversed(number);
                PrintTheNumberWithSecondAndThirdDigitsReversed(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
    
        }

        private static void ValidateCountOfNumberDigits(int number)
        {
            if (number.ToString().Length != 4)
            {
                throw new ArgumentException("Must be four digit number!");
            }
        }

        private void PrintTheNumberWithSecondAndThirdDigitsReversed(int number)
        {
            string numAsString = number.ToString();


            string result = numAsString[0].ToString()
                            + numAsString[2].ToString()
                            + numAsString[1].ToString()
                            + numAsString[3].ToString();

            Writer.WriteLine($"Third and second digits reversed: {result}");
        }

        private void PrintNumberWithFirstAndLastDigitsReversed(int number)
        {
            string numAsString = number.ToString();

  
            string result = numAsString[3].ToString()
                            + numAsString[1].ToString()
                            + numAsString[2].ToString()
                            + numAsString[0].ToString();

            Writer.WriteLine($"First and last digits reversed: {result}");
        }

        private void PrintTheReversedNumber(int number)
        {
            string result = string.Join("", number.ToString().ToCharArray().Reverse());

            Writer.WriteLine($"Reversed number is equal to: {result}");
        }

        private void PrintSumOfTheDigits(int number)
        {
            int result = 0;

            foreach (char digit in number.ToString())
            {
                result += int.Parse(digit.ToString());
            }

            Writer.WriteLine($"Sum of the digits is equal to: {result}");
        }

        private int EnterTheNumber()
        {
            Writer.WriteLine("Please enter a four-digits number");
            return int.Parse(Reader.ReadLine());
        }
    }
}
