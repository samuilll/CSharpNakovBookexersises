using System;
using System.Linq;
using Utilities;
using Utilities.Exceptions;


namespace Chapter_12_ExceptionHandling.Problem11
{
    class Problem_11 : Problem
    {
        private string DefaultPath = "../../../Problem11/text.txt";

        public override void Run()
        {
            FileManager manager = new FileManager();

            try
            {
                Writer.WriteLine("Checking if the file has a row without digit. If has - throw a custom exception");

                string fileName = DefaultPath.Split('\\').Last();

                string content = manager.ReadAllText(DefaultPath);

                string[] lines = content.Split(Environment.NewLine).ToArray();

                manager.ValidateFile(fileName, lines);

                Writer.WriteLine("The file was successfully parsed!");
            }
            catch (FileParseException ex)
            {
                throw ex;
            }
        }
    }
}