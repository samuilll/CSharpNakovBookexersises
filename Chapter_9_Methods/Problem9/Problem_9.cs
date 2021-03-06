﻿using System;
using Chapter_9_Methods.Problem11.Services;
using Utilities;

namespace Chapter_9_Methods.Problem9
{
    //Find max number in the specified range of an array and sort items in descending order
    class Problem_9 : Problem
    {
        public override void Run()
        {
            ArrayService service = new ArrayService();
            decimal[] sequence = service.InsertNonEmptySequence();

            bool success = false;

            while (!success)
            {
                Console.WriteLine($"Please enter starting index in the range[0,{sequence.Length - 1}]:");
                int startIndex = int.Parse(Console.ReadLine());

                Console.WriteLine(
                    $"Please enter last index up to {sequence.Length - 1} and bigger or equal to than {startIndex}:");
                int endIndex = int.Parse(Console.ReadLine());

                int indexOfMaxNumber = service.FindMaxInRangeIndex(sequence, startIndex, endIndex);
                decimal result = sequence[indexOfMaxNumber];

                Console.WriteLine("Value of max member in selected subsequence is:");
                Console.WriteLine(result.ToString("f2"));

                success = true;
            }

            decimal[] sortedArray = service.SortDescending(sequence);

            Console.WriteLine("Descending sorted array:");
            Console.WriteLine(string.Join(", ", sortedArray));
        }
    }
}