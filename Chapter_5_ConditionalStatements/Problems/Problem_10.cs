using System;
using Utilities.Contracts;

namespace Chapter_5.Problems
{
     class Problem_10 : IRunnable
    {
        private const string InvalidPointsErrorMessage = "Points must be between 1 and 9!";

        public void Run()
        {
            Console.WriteLine("Please insert entry points:");
            int entryPoints = int.Parse(Console.ReadLine());

            if (entryPoints <= 0 || entryPoints > 9)
            {
                Console.WriteLine(InvalidPointsErrorMessage);

                return;
            }

            int outputPoints = 0;

            switch (entryPoints)
            {
                case 1:
                case 2:
                case 3:
                    outputPoints = entryPoints * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    outputPoints = entryPoints * 100;
                    break;
                case 7:
                case 8:
                case 9:
                    outputPoints = entryPoints * 1000;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Output:");
            Console.WriteLine(outputPoints);
        }
    }
}
