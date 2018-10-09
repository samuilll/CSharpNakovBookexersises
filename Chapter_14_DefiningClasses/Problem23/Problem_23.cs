using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Chapter_14_DefiningClasses.Problem23
{
    class Problem_23 : Problem
    {
        public override void Run()
        {
            GenericList<string> testingList = new GenericList<string>();

            testingList.Add("Hallo");

            testingList.Add("Bimbo");

            testingList.Insert("Hoho", 1);

            Writer.WriteLine(testingList[0]);

            testingList.RemoveAt(1);

            Writer.WriteLine(testingList.ToString());

            string name = testingList.GetByIndex(1);
            ;
        }
    }
}
