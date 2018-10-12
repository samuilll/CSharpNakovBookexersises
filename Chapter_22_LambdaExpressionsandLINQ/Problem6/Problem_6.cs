using System;
using System.Linq;
using Utilities;

namespace Chapter_22_LambdaExpressionsandLINQ.Problem6
{
    class Problem_6 : Problem
    {
        public override void Run()
        {
            Writer.WriteLine("Please enter a sequence of integers which will be checked for division to 7 and 3 ");
            int[] numbers = Reader.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] selectedNums = numbers
                .Where(n => n % 3 == 0 && n % 7 == 0)
                .ToArray();

            //SelectionWithLINQ(numbers);
            PrintTheResult(selectedNums);
        }

        private void PrintTheResult(int[] selectedNums)
        {
            if (!selectedNums.Any())
            {
                Writer.WriteLine("No numbers");
            }
            else
            {
                Writer.WriteLine("Your numbers are:");
                Writer.WriteLine(string.Join(", ", selectedNums));
            }
        }

        private void SelectionWithLINQ(int[] numbers)
        {
            var selectedNumbers =
                from num in numbers
                where num % 3 == 0 && num % 7 == 0
                select num;

            foreach (var num in selectedNumbers)
            {
                Writer.WriteLine(num);
            }
        }
    }
}