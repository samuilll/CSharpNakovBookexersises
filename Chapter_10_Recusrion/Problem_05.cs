using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Utilities;

namespace Chapter_10_Recusrion
{
    class Problem_05:Problem
    {
        public override void Run()
        {
            Writer.WriteLine("Please enter a sequence of numbers:");
            string[] words = this.Reader.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> output = new List<string>();

            string[] bytesStringArray = CreateByteArrayAsStringArray(words.Length);
       
            for (int i = 0; i < bytesStringArray.Length; i++)
            {
                AddCurrentCombinationInTheOutput(words, output, bytesStringArray, i);
            }

            Writer.WriteLine("Combinations:");
            Writer.WriteLine(string.Join(", ", output));
        }

        private static void AddCurrentCombinationInTheOutput(string[] words, List<string> output, string[] bytesStringArray, int i)
        {
            List<string> currentCombination = new List<string>();

            string byteAsString = bytesStringArray[i];

            for (int charIndexer = 0; charIndexer < byteAsString.Length; charIndexer++)
            {
                char currentChar = byteAsString[charIndexer];

                if (currentChar == '1')
                {
                    currentCombination.Add(words[charIndexer]);
                }
            }

            output.Add($"({string.Join(" ", currentCombination)})");
        }

        private string[] CreateByteArrayAsStringArray(int wordsLength)
        {
            int byteStringArrayLength = (int)Math.Pow(2, wordsLength);

            string[] bytesStringArray = new string[byteStringArrayLength];

            bytesStringArray[0] = new string('0', wordsLength);

            for (int i = 1; i < byteStringArrayLength; i++)
            {
                bytesStringArray[i] = Convert.ToString(i + 1, 2);

                bytesStringArray[i] = (BigInteger.Parse(bytesStringArray[i])).ToString($"D{wordsLength}");
            }

            return bytesStringArray;
        }
    }
}
