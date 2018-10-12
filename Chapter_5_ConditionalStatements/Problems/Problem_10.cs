using System.IO;
using Utilities;

namespace Chapter_5_ConditionalStatements.Problems
{
    class Problem_10 : Problem
    {
        private const string InvalidPointsErrorMessage = "Points must be between 1 and 9!";

        public override void Run()
        {
            Writer.WriteLine("Please insert entry points:");
            int entryPoints = int.Parse(this.Reader.ReadLine());

            if (entryPoints <= 0 || entryPoints > 9)
            {
                throw new InvalidDataException(InvalidPointsErrorMessage);
            }

            int outputPoints = 0;

            outputPoints = MultiplyPoints(entryPoints, outputPoints);
            DisplayTheResult(outputPoints);
        }

        private void DisplayTheResult(int outputPoints)
        {
            Writer.WriteLine("Output:");
            Writer.WriteLine(outputPoints);
        }

        private static int MultiplyPoints(int entryPoints, int outputPoints)
        {
            switch (entryPoints)
            {
                case 1:
                case 2:
                case 3:
                {
                    outputPoints = entryPoints * 10;
                    break;
                }
                case 4:
                case 5:
                case 6:
                {
                    outputPoints = entryPoints * 100;
                    break;
                }
                case 7:
                case 8:
                case 9:
                {
                    outputPoints = entryPoints * 1000;
                    break;
                }
            }

            return outputPoints;
        }
    }
}