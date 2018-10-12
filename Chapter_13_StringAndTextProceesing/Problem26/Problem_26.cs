using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Chapter_13_StringAndTextProceesing.Problem26
{
    class Problem_26 : Problem
    {
        private const string DefaultPath = "../../../Problem26/layout.html";

        public override void Run()
        {
            FileManager manager = new FileManager();

            Stack<char> tagData = new Stack<char>();

            Writer.WriteLine(
                "Please enter path of the a html file you want to have without tags (for default file press \"Enter\")");
            string path = this.Reader.ReadLine();

            if (path == string.Empty)
            {
                path = DefaultPath;
            }

            string fileName = path.Split('\\').Last();
            manager.IsHtmlValidation(fileName);

            string content = manager.ReadAllText(path);

            StringBuilder sb = new StringBuilder();

            InspectTheFile(tagData, content, sb);

            string result = ExtractResult(sb);

            Writer.WriteLine(result);
        }

        private static void InspectTheFile(Stack<char> tagData, string content, StringBuilder sb)
        {
            foreach (char ch in content)
            {
                OpenTagIfNecessary(tagData, sb, ch);

                bool isTagOpen = tagData.Any();

                AppendCharIfNecessary(sb, ch, isTagOpen);
                CloseTagIfNecessary(tagData, ch, isTagOpen);
            }
        }

        private static string ExtractResult(StringBuilder sb)
        {
            string result = sb.ToString();

            string[] resultArgs = result.Split(new char[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries)
                .Where(l => !(string.IsNullOrEmpty(l) || string.IsNullOrWhiteSpace(l)))
                .Select(l => l.Trim())
                .ToArray();

            result = string.Join(Environment.NewLine, resultArgs);
            return result;
        }

        private static void CloseTagIfNecessary(Stack<char> tagData, char ch, bool isTagOpen)
        {
            if (ch == '>')
            {
                if (isTagOpen)
                {
                    tagData.Pop();
                }
            }
        }

        private static void AppendCharIfNecessary(StringBuilder sb, char ch, bool isTagOpen)
        {
            if (!isTagOpen)
            {
                sb.Append(ch);
            }
        }

        private static void OpenTagIfNecessary(Stack<char> tagData, StringBuilder sb, char ch)
        {
            if (ch == '<')
            {
                tagData.Push(ch);
                sb.Append(' ');
            }
        }
    }
}