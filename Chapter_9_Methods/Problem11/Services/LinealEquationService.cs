using System;
using System.Text.RegularExpressions;
using Utilities;

namespace Chapter_9_Methods.Problem11.Services
{
    class LinealEquationService : Problem
    {
        public override void Run()
        {
            Writer.WriteLine("Please enter equation to evaluate (it must be of type a*x+b=0 where x is unknown):");

            string input = null;
            Regex regex = new Regex("(?<firstNum>[-0-9]+)\\*[A-Z-a-z]\\+(?<secondNum>[0-9]+)=0");
            bool isNonZero = true;

            do
            {
                try
                {
                    input = this.Reader.ReadLine();

                    Match match = regex.Match(input);

                    string firstNumAsString = match.Groups["firstNum"].Value;
                    string secondNumAsString = match.Groups["secondNum"].Value;

                    decimal firstNum = decimal.Parse(firstNumAsString);
                    decimal secondNum = decimal.Parse(secondNumAsString);

                    isNonZero = firstNum != 0;

                    if (!isNonZero)
                    {
                        continue;
                    }

                    decimal result = secondNum * (-1) / firstNum;

                    Writer.WriteLine("The result is:");
                    Writer.WriteLine(result);
                }
                catch (Exception e)
                {
                    Writer.WriteLine(e.Message);
                }
            } while (!regex.IsMatch(input) || !isNonZero);
        }
    }
}