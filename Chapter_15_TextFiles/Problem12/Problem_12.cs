using System;
using System.Linq;
using Utilities;

namespace Chapter_15_TextFiles.Problem12
{
    class Problem_12 : Problem
    {
        private const string FirstFilePath = "../../../Problem12/words.txt";

        private const string SecondFilePath = "../../../Problem12/text.txt";

        public override void Run()
        {
            FileManager manager = new FileManager();

            string[] firstFileDataLines = null;
            string secondFileAllText = string.Empty;

            try
            {
                firstFileDataLines = manager.ReadAllLines(FirstFilePath);
                secondFileAllText = manager.ReadAllText(SecondFilePath);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string[] wordsToDelete = GetNeedlessWords(secondFileAllText);

            RemoveNeedlessWords(firstFileDataLines, wordsToDelete);

            manager.WriteAllLines(FirstFilePath, firstFileDataLines);

            Writer.WriteLine("Operations was successfully completed. You can see the files");
        }

        private static string[] GetNeedlessWords(string secondFileAllText)
        {
            return secondFileAllText
                .Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }

        private static void RemoveNeedlessWords(string[] firstFileDataLines, string[] wordsToDelete)
        {
            for (int i = 0; i < firstFileDataLines.Length; i++)
            {
                string line = firstFileDataLines[i];

                foreach (var wordToDelete in wordsToDelete)
                {
                    if (line.Contains(wordToDelete))
                    {
                        firstFileDataLines[i] = line.Replace(wordToDelete, string.Empty);
                    }
                }
            }
        }
    }
}
