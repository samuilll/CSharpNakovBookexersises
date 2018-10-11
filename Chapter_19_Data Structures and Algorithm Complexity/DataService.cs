using System;
using System.Collections.Generic;
using System.Linq;
using Chapter_19_Data_Structures_and_Algorithm_Complexity.Problem3;
using Chapter_19_Data_Structures_and_Algorithm_Complexity.Problem6;

namespace Chapter_19_Data_Structures_and_Algorithm_Complexity
{
    class DataService
    {
        public  void LoadData(Dictionary<decimal, HashSet<Article>> storage)
        {
            Random randomizer = new Random();

            for (int i = 0; i < 10000000; i++)
            {
                string title = "Custom title";
                string barCode = "Custom barcode";
                string manufacturer = "Custom manufacturer";
                decimal price = randomizer.Next(0, 100000);

                Article article = new Article()
                {
                    Manufacturer = manufacturer,
                    Price = price,
                    Barcode = barCode,
                    Title = title
                };

                if (!storage.ContainsKey(price))
                {
                    storage[price] = new HashSet<Article>();
                }
                storage[price].Add(article);
            }
      
        }

        public HashSet<Article> GetSearchedItemsCount(int firstPrice, int secondPrice, Dictionary<decimal, HashSet<Article>> storage)
        {
            HashSet<Article> selectedArticles = new HashSet<Article>();

            var selectedSets = storage
                .Where(kvp => kvp.Key > firstPrice && kvp.Key < secondPrice)
                .Select(kvp => kvp.Value)
                .ToHashSet();

            foreach (var set in selectedSets)
            {
                selectedArticles.UnionWith(set);
            }
            return selectedArticles;
        }

        public void SplitDataAndFillTheDataStrucure(SortedDictionary<string, SortedSet<Student>> dataStorage, string[] dataLines)
        {
            foreach (string line in dataLines)
            {
                string[] args = line
                    .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string studentFullName = args[0];
                string course = args[1];

                string[] studentNamesSplit = studentFullName.Split(' ');
                string firstName = studentNamesSplit[0];
                string lastName = studentNamesSplit[1];

                Student student = new Student(firstName,lastName);

                if (!dataStorage.ContainsKey(course))
                {
                    dataStorage[course] = new SortedSet<Student>();
                }

                dataStorage[course].Add(student);
            }
        }
    }
}
