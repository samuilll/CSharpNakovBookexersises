﻿using System;
using System.Linq;
using Utilities;

namespace Chapter_9_Methods.Problem11.Services
{
    internal class ArrayService : Problem
    {
        public override void Run()
        {
            decimal[] sequence = this.InsertNonEmptySequence();

            decimal average = sequence.Average();

            Writer.WriteLine("Average value:");
            Writer.WriteLine(average.ToString("f2"));
        }

        internal int FindMaxInRangeIndex(decimal[] sequence, int startIndex, int endIndex)
        {
            if (startIndex > endIndex || !IsIndexValid(sequence, startIndex) || !IsIndexValid(sequence, endIndex))
            {
                Writer.WriteLine("Invalid index!");
            }

            decimal maxElement = int.MinValue;
            int maxIndex = -1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                decimal currentNum = sequence[i];

                if (currentNum > maxElement)
                {
                    maxElement = currentNum;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }


        internal decimal[] InsertNonEmptySequence()
        {
            Writer.WriteLine("Please enter a sequence of numbers");

            decimal[] sequence = null;

            while (sequence == null || sequence.Length == 0)
            {
                sequence = this.Reader.ReadLine()
                    .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToArray();
            }

            return sequence;
        }


        internal decimal[] SortDescending(decimal[] sequence)
        {
            decimal[] sortedArray = new decimal[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                sortedArray[i] = sequence[i];
            }

            for (int i = 0; i < sortedArray.Length; i++)
            {
                int currentMaxIndex = this.FindMaxInRangeIndex(sortedArray, i, sortedArray.Length - 1);

                MoveMaxForward(sortedArray, currentMaxIndex, i);
            }

            return sortedArray;
        }

        private void MoveMaxForward(decimal[] sortedArray, int currentMaxIndex, int index)
        {
            decimal temp = sortedArray[currentMaxIndex];

            sortedArray[currentMaxIndex] = sortedArray[index];

            sortedArray[index] = temp;
        }

        private static bool IsIndexValid(decimal[] sequence, int startIndex)
        {
            return startIndex >= 0 || startIndex < sequence.Length;
        }
    }
}