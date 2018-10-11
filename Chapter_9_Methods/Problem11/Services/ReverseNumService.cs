using System.Linq;
using Utilities;

namespace Chapter_9_Methods.Problem11.Services
{
    class ReverseNumService:Problem
    {

        public override void Run()
        {
            decimal num = this.InsertNonNegativeValue();

            decimal reversedNum = ReverseNumber(num);

            Writer.WriteLine("Reversed num:");
            Writer.WriteLine($"Reversed num is equal to {reversedNum}");
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
            Writer.WriteLine("Please enter a non negative number to reverse");
            string valueAsString = this.Reader.ReadLine();

            decimal value = 0;

            while (!decimal.TryParse(valueAsString, out value) || value<0)
            {
                Writer.WriteLine("Invalid value!");

                valueAsString = this.Reader.ReadLine();
            }

            return value;
        }
    }
}
