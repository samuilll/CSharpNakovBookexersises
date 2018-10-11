using System;
using System.Linq;
using Utilities;
using Utilities.Exceptions;


namespace Chapter_12_ExceptionHandling.Problem11
{
    class Problem_11 : Problem
    {
        public override void Run()
        {
           FileManager manager = new FileManager();

            try
            {
                //??? add files please
                Writer.WriteLine("Please enter the path of a file:");
                string path = this.Reader.ReadLine();
                string fileName = path.Split('\\').Last();

                string content = manager.ReadAllText(path);

                string[] lines = content.Split(Environment.NewLine).ToArray();

                manager.ValidateFile(fileName,lines);

                Writer.WriteLine("The file was successfully parsed!");
            }
            catch (FileParseException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
