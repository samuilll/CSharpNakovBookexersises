using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Chapter_18_DictionariesHashTablesAndSets.Problem5
{
    class Problem_5 : Problem
    {
        private const string Path = "../../../text.txt";

        public override void Run()
        {
            FileManager manager = new FileManager();

            Dictionary<string, int> dataStorage = new Dictionary<string, int>();

            string[] words = manager.ReadAllText(Path)
                .Split(new string[] {Environment.NewLine, " "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StoreDataIntoTheStorage(dataStorage, words);

            PrintTheResult(dataStorage);
        }

        private void PrintTheResult(Dictionary<string, int> dataStorage)
        {
            foreach (KeyValuePair<string, int> pair in dataStorage.OrderBy(kvp => kvp.Value))
            {
                Writer.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }

        private static void StoreDataIntoTheStorage(Dictionary<string, int> dataStorage, string[] words)
        {
            foreach (string word in words)
            {
                if (!dataStorage.ContainsKey(word))
                {
                    dataStorage[word] = 0;
                }

                dataStorage[word] += 1;
            }
        }
    }
}