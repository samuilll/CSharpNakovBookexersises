using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Chapter_1_IntroductionToProgramming.Problem10
{
    class Problem_10:Problem
    {
        public override void Run()
        {
            int positiveNum = 2;
            int negativeNum = -3;

            int[] nums = new int[100];

            for (int i = 0; i < 100; i+=2)
            {
                nums[i] = positiveNum;
                nums[i + 1] = negativeNum;

                positiveNum += 2;
                negativeNum -= 2;
            }

            Writer.WriteLine("First 100 numbers of the sequence 2,-3,4,-5,6...:");
            Writer.WriteLine(string.Join(", ",nums));
        }
    }
}
