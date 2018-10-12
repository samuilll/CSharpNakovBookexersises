using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utilities;

namespace Chapter_17_TreesAndGraphs.Prooblem11
{
    class Problem_11:Problem
    {
        private const string SearchedExtension = ".exe";
        public override void Run()
        {
            Writer.WriteLine("Find all its subdirectories recursively and prints all the files which have extension *.exe");
            Writer.WriteLine("Please enter the directory to traverse path");
            string path = Reader.ReadLine();

            this.InspectTheFolder(path);
        }

        private void InspectTheFolder(string path)
        {
            try
            {
                DirectoryInfo dirToInspect = new DirectoryInfo(path);

                Console.Write($"Path: {path}");

                //Select only file names with searched extension
                string[] searchedFileNames = dirToInspect
                    .GetFiles()
                    .Where(f => f.Extension == SearchedExtension)
                    .Select(f => f.Name)    
                    .ToArray();

                Writer.WriteLine(path);
                Writer.WriteLine(string.Join($"{Environment.NewLine}--", searchedFileNames));

                DirectoryInfo[] subDirsInfo = dirToInspect.GetDirectories();

                foreach (DirectoryInfo subDir in subDirsInfo)
                {
                    InspectTheFolder(subDir.FullName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
