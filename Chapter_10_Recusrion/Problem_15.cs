using System;
using System.IO;
using System.Linq;
using Utilities;

namespace Chapter_10_Recusrion
{
   //Show all files, subfolders and subfolders' files in the folder
    class Problem_15 : Problem
    {
        public override void Run()
        {
            Writer.WriteLine("Please enter the path of a folder you want to inspect:");
            string path =   this.Reader.ReadLine();

            InspectTheFolder(path);

        }

        private  void InspectTheFolder(string path)
        {
            try
            {
                DirectoryInfo dirToInspect = new DirectoryInfo(path);

                Console.Write($"Path: {path}");

                //show files
                Writer.WriteLine(string.Join($"{Environment.NewLine}--", dirToInspect.GetFiles().Select(f => f.Name)));

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
