using System;
using System.Linq;
using Utilities.Contracts;

namespace Chapter_9_Methods.Task11.Services
{
  public  class ReverseNumService:IRunnable
    {
      
        public void Run()
        {
            decimal num = this.InsertNonNegativeValue();

            decimal reversedNum = ReverseNumber(num);

            Console.WriteLine("Reversed num:");
            Console.WriteLine("Reversed num is equal to {0}",reversedNum);
        }

        private decimal ReverseNumber(decimal num)
        {
            string valueAsString = num.ToString();
            string reversedValueAsString = string.Join("", valueAsString.ToCharArray().Reverse());
            decimal result = decimal.Parse(reversedValueAsString);

            return result;
        }

        private decimal InsertNonNegativeValue()
        {
            Console.WriteLine("Please enter a non negative number to reverse");
            string valueAsString = Console.ReadLine();

            decimal value = 0;

            while (!decimal.TryParse(valueAsString, out value) || value<0)
            {
                Console.WriteLine("Invalid value!");

                valueAsString = Console.ReadLine();
            }

            return value;
        }
    }
}
