using System.Collections.Generic;
using System.Diagnostics;
using Utilities;

namespace Chapter_19_Data_Structures_and_Algorithm_Complexity.Problem6
{
    class Problem_6 : Problem
    {
        public override void Run()
        {
            Dictionary<decimal, HashSet<Article>> storage = new Dictionary<decimal, HashSet<Article>>();
            DataService dataService = new DataService();

            Stopwatch stop = new Stopwatch();
            stop.Start();

            Writer.WriteLine("Loading milions of articles...Please be patient (it will take around 15 seconds)");

            dataService.LoadData(storage);

            Writer.WriteLine($"Ten milions articles have just been loaded in {stop.Elapsed.TotalMilliseconds} miliseconds");
            Writer.WriteLine("Please enter first integer value in the range [1,99999].");
            int firstValue = int.Parse(Reader.ReadLine());
            Writer.WriteLine("Please enter one more integer value in the range [1,99999].");
            int secondValue = int.Parse(Reader.ReadLine());

            stop.Restart();

            HashSet<Article> articles =  dataService.GetSearchedItemsCount(firstValue,secondValue,storage);
            int itemsCount = articles.Count;

            Writer.WriteLine($"{itemsCount} articles with price in the range[{firstValue},{secondValue}] was obtained in {stop.Elapsed.TotalMilliseconds} miliseconds");           ;
        }

       
    }
}
    
