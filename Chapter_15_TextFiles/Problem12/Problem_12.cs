using System;
using System.Linq;
using Utilities;

namespace Chapter_15_TextFiles.Problem12
{
    class Problem_12 : Problem
    {
        private const string criterionFilePath = "../../../Problem12/words.txt";

        private const string fileToInspectPath = "../../../Problem12/text.txt";

        public override void Run()
        {
            FileManager manager = new FileManager();

            string[] fileToInspectLinesDataLines = null;
            string criterionAllText = string.Empty;

            try
            {
                fileToInspectLinesDataLines = manager.ReadAllLines(fileToInspectPath);
                criterionAllText = manager.ReadAllText(criterionFilePath);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            string[] wordsToDelete = GetNeedlessWords(criterionAllText);

            RemoveNeedlessWords(fileToInspectLinesDataLines, wordsToDelete);

            manager.WriteAllLines(fileToInspectPath, fileToInspectLinesDataLines);

            Writer.WriteLine("Operations was successfully completed. You can see the files");
        }

        private static string[] GetNeedlessWords(string content)
        {
            return content
                .Split(new char[] { '\r','\n','.',',',':',';',' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }

        private static void RemoveNeedlessWords(string[] lines, string[] wordsToDelete)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].ToLower();

                foreach (var wordToDelete in wordsToDelete)
                {
                    if (line.Contains(wordToDelete.ToLower()))
                    {
                        line = line.Replace(wordToDelete, string.Empty);
                    }
                }

                lines[i] = line;
            }
        }
    }
}
