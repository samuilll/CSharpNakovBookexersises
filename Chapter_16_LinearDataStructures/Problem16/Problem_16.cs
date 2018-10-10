using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utilities;

namespace Chapter_16_LinearDataStructures.Problem16
{
    class Problem_16:Problem
    {

        public override void Run()
        {
            Queue<string> queue = new Queue<string>();

            Writer.WriteLine("Please enter the directory path");
            string path = Reader.ReadLine();
            queue.Enqueue(path);

            while (queue.Any())
            {
                string currentPath = queue.Dequeue();

                Writer.WriteLine(currentPath);

                try
                {
                    DirectoryInfo currentDirInfo = new DirectoryInfo(currentPath);

                    foreach (string innerPath in currentDirInfo.GetDirectories().Select(d => d.FullName))
                    {
                        queue.Enqueue(innerPath);
                    }               
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }                
            }
        }
    }
}
