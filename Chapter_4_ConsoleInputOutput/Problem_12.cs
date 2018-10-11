using System.Numerics;
using System.Text;
using Utilities;

namespace Chapter_4_ConsoleInputOutput
{
    class Problem_12:Problem
    {
        public override void Run()
        {
            StringBuilder sb = new StringBuilder();
      
            for (int i = 0; i < 100; i++)
            {
                BigInteger fibonacciInNumber = GetNextFib(i);

                sb.Append($"{fibonacciInNumber.ToString()}, ");
            }

            Writer.WriteLine("First 100 Fibonacci numbers:");
            Writer.WriteLine(sb.ToString().TrimEnd(',',' '));

        }

        private  BigInteger GetNextFib(long number)
        {
            if (number == 0)
            {
                return 0;
            }
            if (number == 1 || number == 2)
            {
                return 1;
            }

            BigInteger previousNumber = 1;

            BigInteger currentNumber = 2;

            BigInteger nextNumber = 0;

            for (long i = 3; i < number; i++)
            {
                nextNumber = previousNumber + currentNumber;

                previousNumber = currentNumber;

                currentNumber = nextNumber;
            }

            return currentNumber;
        }
    }
}
