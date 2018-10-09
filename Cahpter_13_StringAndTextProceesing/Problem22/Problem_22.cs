using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Cahpter_13_StringAndTextProceesing.Problem22
{
    class Problem_22:Problem
    {
        public override void Run()
        {
            Writer.WriteLine("Please enter the string you want to inspect:");
            string text = Reader.ReadLine().Replace(" ", string.Empty);

            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            SetLettersInfoInDictionary(text, result);

            PrintTheResult(result);
        }

        private void PrintTheResult(SortedDictionary<char, int> result)
        {
            foreach (KeyValuePair<char, int> pair in result)
            {
                Writer.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }

        private static void SetLettersInfoInDictionary(string text, SortedDictionary<char, int> result)
        {
            foreach (char ch in text)
            {
                if (!char.IsLetter(ch))
                {
                    continue;
                }

                char letterToUpper = char.ToUpper(ch);

                if (!result.ContainsKey(letterToUpper))
                {
                    result[letterToUpper] = 0;
                }

                result[letterToUpper] += 1;
            }
        }
    }
}
