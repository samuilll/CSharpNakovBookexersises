﻿using System;
using Chapter_11_CreatingAndUsingObjects.Problem11;
using Chapter_11_CreatingAndUsingObjects.Problem9;
using Utilities;

namespace Chapter_11_CreatingAndUsingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Problem problem11 = new Problem_11();
           // problem11.Run();

            Problem problem9 = new Problem_9();
            problem9.Run();
        }
    }
}