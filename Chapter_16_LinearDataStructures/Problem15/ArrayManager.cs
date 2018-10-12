using System;
using System.Linq;
using Utilities;

namespace Chapter_16_LinearDataStructures.Problem15
{
    class ArrayManager
    {
        public Writer Writer { get; }
        public Reader Reader { get; }

        public ArrayManager(Writer writer, Reader rEader)
        {
            Writer = writer;
            Reader = rEader;
        }

        public int[] InitializeTheArray()
        {
            Writer.WriteLine("Please enter an array of numbers to be sorted:");

            int[] numbers = Reader
                .ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return numbers;
        }

        public void DisplayTheResult(int[] numbers)
        {
            Writer.WriteLine(string.Join(", ", numbers));
        }

        public void SortTheArrayWithBubbleMethod(int[] numbers)
        {
            bool hasChange = true;

            while (hasChange)
            {
                hasChange = false;

                for (int index = 0; index < numbers.Length - 1; index++)
                {
                    if (numbers[index] > numbers[index + 1])
                    {
                        SwapNumbers(numbers, index);

                        hasChange = true;
                    }
                }
            }
        }

        public void SwapNumbers(int[] numbers, int index)
        {
            int temp = numbers[index];
            numbers[index] = numbers[index + 1];
            numbers[index + 1] = temp;
        }
    }
}