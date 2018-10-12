using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Chapter_15_TextFiles.Problem13
{
    class Problem_13 : Problem
    {
        private const string FileToReadPath = "../../../Problem13/words.txt";

        private const string FileToInspectPath = "../../../Problem13/text.txt";

        private const string ResultFilePath = "../../../Problem13/result.txt";


        public override void Run()
        {
            FileManager manager = new FileManager();

            string[] fileToReadWords = null;
            string[] fileToInspectWords = null;

            try
            {
                fileToReadWords = GetWordsToRead(manager);
                fileToInspectWords = GetWordsToInspect(manager);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Dictionary<string, int> resultAsDictionary = CountOccurencesOfTheWords(fileToReadWords, fileToInspectWords);

            string resultAsString = GetResultAsString(resultAsDictionary);

            manager.WriteAllText(ResultFilePath, resultAsString);

            Writer.WriteLine("Operations was successfully completed. You can see the files");
        }

        private static string GetResultAsString(Dictionary<string, int> resultData)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> pair in resultData.OrderByDescending(p => p.Value))
            {
                sb.AppendLine($"{pair.Key}->{pair.Value} times");
            }

            return sb.ToString();
        }

        private static Dictionary<string, int> CountOccurencesOfTheWords(string[] fileToReadWords,
            string[] fileToInspectWords)
        {
            Dictionary<string, int> resultData = new Dictionary<string, int>();

            foreach (string wordToRead in fileToReadWords)
            {
                foreach (string wordToInspect in fileToInspectWords)
                {
                    if (wordToRead == wordToInspect)
                    {
                        if (!resultData.ContainsKey(wordToRead))
                        {
                            resultData[wordToRead] = 0;
                        }

                        resultData[wordToRead] += 1;
                    }
                }
            }

            return resultData;
        }

        private static string[] GetWordsToInspect(FileManager manager)
        {
            return string
                .Join(Environment.NewLine, manager.ReadAllLines(FileToInspectPath))
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }

        private static string[] GetWordsToRead(FileManager manager)
        {
            return string
                .Join(Environment.NewLine, manager.ReadAllLines(FileToReadPath))
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
    }
}