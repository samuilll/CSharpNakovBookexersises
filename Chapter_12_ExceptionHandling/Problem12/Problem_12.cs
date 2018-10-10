using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Utilities;

namespace Chapter_12_ExceptionHandling.Problem12
{
    class Problem_12 : Problem
    {
        public override void Run()
        {
           FileManager manager = new FileManager();

            try
            {
                Writer.WriteLine("Please the the path of the file:");
                string path = this.Reader.ReadLine();

                string content = manager.ReadAllText(path);

                this.Writer.WriteLine("Content:");
                this.Writer.WriteLine(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
