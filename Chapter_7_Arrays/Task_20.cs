﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities.Contracts;

namespace Chapter_7_Arrays
{
    public class Task_20 : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Please insert the number sequence");
            List<int> myList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList(); 

            Console.WriteLine("Please insert searched sum target:");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(FindSum(myList, target).Any());      
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

