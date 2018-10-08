using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities.Contracts;

namespace Chapter_7_Arrays
{
    class Problem_06:IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Please insert sequence:");

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[numbers.Length];
            int[] prev = new int[numbers.Length];

            len[0] = 1;
            prev[0] = -1;

            int bestLength = 0;
            int bestIndex = 0;

            for (int firstLoopIndex = 1; firstLoopIndex < numbers.Length; firstLoopIndex++)
            {
                var hasChange = false;

                for (int secondLoopIndex = 0; secondLoopIndex < firstLoopIndex; secondLoopIndex++)  
                {
                    int num1 = numbers[firstLoopIndex];
                    int num2 = numbers[secondLoopIndex];

                    if (num1 > num2 && len[firstLoopIndex] < len[secondLoopIndex] + 1)
                    {
                        prev[firstLoopIndex] = secondLoopIndex;
                        len[firstLoopIndex] = len[secondLoopIndex] + 1;

                        hasChange = true;

                        if (len[firstLoopIndex] > bestLength)
                        {
                            bestLength = len[firstLoopIndex];
                            bestIndex = firstLoopIndex;
                        }
                    }
                }
                if (!hasChange)
                {
                    len[firstLoopIndex] = 1;
                    prev[firstLoopIndex] = -1;
                }
            }

            PrintTheResult(numbers, prev, bestIndex);
        }

        private static void PrintTheResult(int[] numbers, int[] prev, int bestIndex)
        {
            List<int> result = new List<int>();

            while (bestIndex != -1)
            {
                result.Add(numbers[bestIndex]);

                bestIndex = prev[bestIndex];
            }

            result.Reverse();

            Console.WriteLine("The longest increasing subsequence:");

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
