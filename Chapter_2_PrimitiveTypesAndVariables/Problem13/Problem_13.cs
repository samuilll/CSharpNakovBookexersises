﻿using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Chapter_2_PrimitiveTypesAndVariables.Problem13
{
    class Problem_13:Problem
    {
        public override void Run()
        {
            try
            {
                Writer.WriteLine("Please enter one number:");
                int firstNum = int.Parse(Reader.ReadLine());
                Writer.WriteLine("Please enter one more number:");
                int secondNum = int.Parse(Reader.ReadLine());

                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;

                Writer.WriteLine($"First number is changed to: {firstNum}");
                Writer.WriteLine($"Second number is changed to: {secondNum}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
