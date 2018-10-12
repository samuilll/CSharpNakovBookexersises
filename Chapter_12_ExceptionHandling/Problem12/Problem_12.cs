using Utilities;

namespace Chapter_12_ExceptionHandling.Problem12
{
    class Problem_12 : Problem
    {
        private string DefaultPath = "../../../Problem12/text.txt";

        public override void Run()
        {
            FileManager manager = new FileManager();

            Writer.WriteLine("Please enter the path of the file or press enter for default path");
            string path = this.Reader.ReadLine();

            if (path == string.Empty)
            {
                path = DefaultPath;
            }

            string content = manager.ReadAllText(path);

            this.Writer.WriteLine("Content:");
            this.Writer.WriteLine(content);
        }
    }
}