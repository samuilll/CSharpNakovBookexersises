using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using Utilities.Contracts;

namespace Chapter_7_Arrays
{
     class Problem_20 : Problem
    {
        // Compute is there is a subset with sum equal to the input target
        public override void Run()
        {
            Console.WriteLine("Please insert the number sequence");
            List<int> myList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList(); 

            Console.WriteLine("Please insert searched sum target:");
            int target = int.Parse(Console.ReadLine());

            bool haveSum = FindSum(myList, target).Any();

            Console.WriteLine("Is there a sum equal to the target:");
            Console.WriteLine(haveSum?"Yes":"No");      
        }

        private List<int> FindSum(List<int> numbers, int target, int index = 0)
            {
                for (int i = index; i < numbers.Count; i++)
                {
                    int remainder = target - numbers[i];

                    if (remainder < 0)
                        continue;

                    else if (remainder == 0)
                        return new List<int>() {numbers[i]};
                    else
                    {
                        List<int> helpList = FindSum(numbers, remainder, i + 1);

                        if (helpList.Count == 0)
                            continue;

                    
                        helpList.Insert(0, numbers[i]);
                        return helpList;
                    }
                }

                return new List<int>();
            }
        }
    }

