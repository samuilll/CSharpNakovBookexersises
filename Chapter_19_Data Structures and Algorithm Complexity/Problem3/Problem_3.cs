using System.Collections.Generic;
using Utilities;

namespace Chapter_19_Data_Structures_and_Algorithm_Complexity.Problem3
{
    class Problem_3:Problem
    {
        private const string Path = @"../../../students.txt";

        public override void Run()
        {
            FileManager fileManager = new FileManager();
            DataService dataService = new DataService();

            SortedDictionary<string, SortedSet<Student>> dataStorage = new SortedDictionary<string, SortedSet<Student>>();

            string[] dataLines = fileManager.ReadAllLines(Path);

            dataService.SplitDataAndFillTheDataStrucure(dataStorage, dataLines);

            DisplayResult(dataStorage);
        }

        private void DisplayResult(SortedDictionary<string, SortedSet<Student>> dataStorage)
        {
            Writer.WriteLine("Sorted info:");
            foreach (KeyValuePair<string, SortedSet<Student>> courseStudentsSetPair in dataStorage)
            {
                string course = courseStudentsSetPair.Key;
                SortedSet<Student> students = courseStudentsSetPair.Value;

                Writer.WriteLine($"{course}: {string.Join(", ", students)}");
            }
        }
    }
}
