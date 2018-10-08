using System;

using Utilities.Contracts;

namespace Chapter_5.Problems
{
     class Problem_08 : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Please insert int, double or string value");

            object obj = Console.ReadLine();

            bool isInteger = int.TryParse(obj.ToString(), out int integerNumber);
            bool isDouble = double.TryParse(obj.ToString(),out double doubleNumber);
            bool isNumber = isInteger || isDouble;

            string result = obj.ToString();

            if (isNumber)
            {
                result = (doubleNumber + 1).ToString();
            }
            else
            {
                result = result + "*";
            }

            Console.WriteLine("Output:");
            Console.WriteLine(result);
        }
    }
}
