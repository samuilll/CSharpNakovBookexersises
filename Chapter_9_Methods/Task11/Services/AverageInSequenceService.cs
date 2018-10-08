using System;
using System.Linq;
using Utilities.Contracts;

namespace Chapter_9_Methods.Task11.Services
{
   public class AverageInSequenceService:IRunnable
    {
        public void Run()
        {
            decimal[] sequence = this.InsertNonEmptySequence();

            decimal average = sequence.Average();

            Console.WriteLine("Average value:");
            Console.WriteLine(average.ToString("f2"));
        }

        private decimal[] InsertNonEmptySequence()
        {
            Console.WriteLine("Please enter sequence members");

            decimal[] sequence = null;

            while (sequence==null||sequence.Length==0)
            {
                try
                {
                        sequence = Console.ReadLine()
                        .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(decimal.Parse)
                        .ToArray();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return sequence;
        }
    }
}
