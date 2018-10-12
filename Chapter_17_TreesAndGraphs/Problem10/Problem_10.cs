using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Utilities;

namespace Chapter_17_TreesAndGraphs.Problem10
{
    class Problem_10 : Problem
    {
        public override void Run()
        {
            Queue<string> queue = new Queue<string>();

            Writer.WriteLine("Breadth first search (BFS), based on a queue, to traverse a directed graph.");
            Writer.WriteLine("Please enter the directory to traverse path");
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